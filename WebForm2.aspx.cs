using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork003
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Repeater1.DataSource = ConnectDB.FixDataTable();
                this.Repeater1.DataBind();
            }

        } //讀取

        protected void btnCreate_Click(object sender, EventArgs e)
        {

            //建立變數已接取TextBox的值
            int sid = Convert.ToInt32(this.TextSid.Text);
            string name = this.Textequipment_name.Text;
            string restoration_time = this.Textrestoration_time.Text;
            string failure_date = this.Textfailure_date.Text;
            string restoration_factory = this.Textrestoration_factory.Text;
            string failure_causet = this.Textfailure_cause.Text;
            string replacement_department = this.Textreplacement_department.Text;
            string note = this.Textnote.Text;

            ConnectDB.CreateFix(sid, name, restoration_time, failure_date, restoration_factory,
            failure_causet, replacement_department, note);

            this.Repeater1.DataSource = ConnectDB.FixDataTable();
            this.Repeater1.DataBind();

        } //新增
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //建立變數已接取TextBox的值
            int sid = Convert.ToInt32(this.TextSid.Text);
            string name = this.Textequipment_name.Text;
            string restoration_time = this.Textrestoration_time.Text;
            string failure_date = this.Textfailure_date.Text;
            string restoration_factory = this.Textrestoration_factory.Text;
            string failure_causet = this.Textfailure_cause.Text;
            string replacement_department = this.Textreplacement_department.Text;
            string note = this.Textnote.Text;

            ConnectDB.UpdateFix(sid, name, restoration_time, failure_date, restoration_factory,
            failure_causet, replacement_department, note);

            this.Repeater1.DataSource = ConnectDB.FixDataTable();
            this.Repeater1.DataBind();

        }  //修改

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(this.TextSid.Text);

            ConnectDB.DeleteFix(sid);

            this.Repeater1.DataSource = ConnectDB.FixDataTable();
            this.Repeater1.DataBind();
        }   //刪除單筆


        protected void Single_Click(object sender, EventArgs e)
        {
            //建立變數以連接TextBox的值
            int sid = Convert.ToInt32(this.TextSid.Text);
            //將變數傳進Method
            this.Repeater1.DataSource = ConnectDB.ReadSingleFix(sid);
            //將回傳值放進GridView
            this.Repeater1.DataBind();

        }  //讀取單筆

        protected void ReadAll_Click(object sener, EventArgs e)
        {
            //將變數傳進Method
            this.Repeater1.DataSource = ConnectDB.ReadAllFix();
            //將回傳值放進GridView
            this.Repeater1.DataBind();
        }  //讀取全部

        protected void Chang_Click(object sender, EventArgs e)  //查詢其他
        {
            //轉跳至其他頁面
            Response.Redirect("https://www.w3schools.com/sql/trysql.asp?filename=trysql_delete");
        }
    }
}