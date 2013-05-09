using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace EVSoft.HRMS.Controls
{
	/// <summary>
	/// Summary description for DepartmentTreeView.
	/// </summary>
	public class DepartmentTreeView : TreeView
	{
		private IContainer components;
		private ImageList NodesIcon;

		public DepartmentTreeView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof (DepartmentTreeView));
			this.NodesIcon = new System.Windows.Forms.ImageList(this.components);
			// 
			// NodesIcon
			// 
			this.NodesIcon.ImageSize = new System.Drawing.Size(16, 16);
			this.NodesIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("NodesIcon.ImageStream")));
			this.NodesIcon.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// DepartmentTreeView
			// 
			this.ImageIndex = 0;
			this.ImageList = this.NodesIcon;
			this.SelectedImageIndex = 0;
			this.Size = new System.Drawing.Size(248, 320);

		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private DataSet dsDepartments = null;
		/// <summary>
		/// Tập hợp các nút có trạng thái check = true trên cây
		/// </summary>
		private ArrayList checkedTreeNodes = new ArrayList();
		//private bool check = true;
		/// <summary>
		/// 
		/// </summary>
		public DataSet DepartmentDataSet
		{
			get { return dsDepartments; }
			set { dsDepartments = value; }
		}
		/// <summary>
		/// Lấy danh sách các nút có trạng thái check = true trên cây
		/// </summary>
		public ArrayList CheckedTreeNodes
		{
			get
			{
				return checkedTreeNodes;
			}
		}

		/// <summary>
		/// Xây dựng cây phòng ban
		/// </summary>
		public void ReBuild()
		{
//			dsDepartments = departmentDO.GetAllDepartments();
			BuildTree();
			this.ExpandNodes(true);
		}

		/// <summary>
		/// Xây dựng cây phòng ban
		/// </summary>
		public void BuildTree1(bool lang)
		{
			this.Nodes.Clear();

			DataRow[] drData = dsDepartments.Tables[0].Select("ParentNode=0");

			if (drData.Length > 0)
			{
				foreach (DataRow dataRow in drData)
				{
					int DepartmentID = Convert.ToInt32(dataRow["DepartmentID"]);

					string DepartmentName = null;
					
					if (lang == true)
					{
						DepartmentName = Convert.ToString(dataRow["DepartmentName"]);
					}
					else
					{
						DepartmentName = Convert.ToString(dataRow["DepartmentNameJP"]);
					}

					TreeNode mynode = new TreeNode();

					mynode.Text = DepartmentName;

					mynode.Tag = DepartmentID;

					mynode.ImageIndex = 0;

					mynode.SelectedImageIndex = 1;

					this.Nodes.Add(mynode);

					if (IsParentDepartment(DepartmentID))
					{
						AddSubDepartment1(ref mynode, DepartmentID,lang);

					}
				}
			}
			drData = null;
		}

		public void BuildTree()
		{
			this.Nodes.Clear();

			DataRow[] drData = dsDepartments.Tables[0].Select("ParentNode=0");

			if (drData.Length > 0)
			{
				foreach (DataRow dataRow in drData)
				{
					int DepartmentID = Convert.ToInt32(dataRow["DepartmentID"]);

					string DepartmentName  = Convert.ToString(dataRow["DepartmentName"]);
					
					TreeNode mynode = new TreeNode();

					mynode.Text = DepartmentName;

					mynode.Tag = DepartmentID;

					mynode.ImageIndex = 0;

					mynode.SelectedImageIndex = 1;

					this.Nodes.Add(mynode);

					if (IsParentDepartment(DepartmentID))
					{
						AddSubDepartment(ref mynode, DepartmentID);

					}
				}
			}
			drData = null;
		}

		/// <summary>
		/// Thêm các nút phòng ban con vào cây phòng ban
		/// </summary>
		/// <param name="ParentNode"></param>
		/// <param name="IParentDepartmentId"></param>
		private void AddSubDepartment1(ref TreeNode ParentNode, int IParentDepartmentId,bool t)
		{
			DataRow[] drData = dsDepartments.Tables[0].Select("ParentNode=" + IParentDepartmentId);

			if (drData.Length > 0)
			{
				foreach (DataRow dataRow in drData)
				{
					int DepartmentID = Convert.ToInt32(dataRow["DepartmentID"]);

					string DepartmentName = null;
					if (t == true)
					{
						DepartmentName = Convert.ToString(dataRow["DepartmentName"]);
					}
					else
					{
						DepartmentName = Convert.ToString(dataRow["DepartmentNameJP"]);
					}

					TreeNode mynode = new TreeNode();

					mynode.Text = DepartmentName;

					mynode.Tag = DepartmentID;

					mynode.ImageIndex = 0;

					mynode.SelectedImageIndex = 1;

					ParentNode.Nodes.Add(mynode);

					if (IsParentDepartment(DepartmentID))
					{
						AddSubDepartment1(ref mynode, DepartmentID,t);
					}
				}
			}

			drData = null;

		}

		private void AddSubDepartment(ref TreeNode ParentNode, int IParentDepartmentId)
		{
			DataRow[] drData = dsDepartments.Tables[0].Select("ParentNode=" + IParentDepartmentId);

			if (drData.Length > 0)
			{
				foreach (DataRow dataRow in drData)
				{
					int DepartmentID = Convert.ToInt32(dataRow["DepartmentID"]);

					string DepartmentName  = Convert.ToString(dataRow["DepartmentName"]);
					

					TreeNode mynode = new TreeNode();

					mynode.Text = DepartmentName;

					mynode.Tag = DepartmentID;

					mynode.ImageIndex = 0;

					mynode.SelectedImageIndex = 1;

					ParentNode.Nodes.Add(mynode);

					if (IsParentDepartment(DepartmentID))
					{
						AddSubDepartment(ref mynode, DepartmentID);
					}
				}
			}

			drData = null;

		}

		/// <summary>
		/// Kiểm tra một phòng ban có phải là cha của các phòng ban khác không
		/// </summary>
		/// <param name="DepartmentID">Mã phòng ban cần kiểm tra</param>
		/// <returns>True nếu phòng ban này là cha của một phòng ban khác</returns>
		public bool IsParentDepartment(int DepartmentID)
		{
			DataRow[] drData = dsDepartments.Tables[0].Select("ParentNode=" + DepartmentID);
			if (drData.Length > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Expand"></param>
		public void ExpandNodes(bool Expand)
		{
			this.SuspendLayout();
			if (Expand)
			{
				this.ExpandAll();
			}
			else
			{
				this.CollapseAll();
			}
			this.ResumeLayout();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnBeforeCheck(TreeViewCancelEventArgs e)
		{
			// get current action		
			bool check = !e.Node.Checked;

			Cursor.Current = Cursors.WaitCursor;
			//
			try
			{
				// check child nodes to reflect parent check state
				CheckNodesRec(e.Node, check);
			}
			catch (Exception ex)
			{
				// ups, exception ?
				Console.WriteLine(ex.Message);
			}
			finally
			{
				// reset the cursor
				Cursor.Current = Cursors.Default;
			}
		}
		/// <summary>
		/// Thiết lập trạng thái check của một nút, thực hiện đệ quy với các nút con
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="check"></param>
		private void CheckNodesRec(TreeNode parent, bool check)
		{
			foreach (TreeNode n in parent.Nodes)
			{
				n.Checked = check;
				//
				if (check)
				{
					checkedTreeNodes.Add(n);
				}
				else
				{
					checkedTreeNodes.Remove(n);
				}
				CheckNodesRec(n, check);
			}
		}
	}
}