using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlModelGenera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) || this.textBox1.Text == "请输入数据库连接字符串")
            {
                MessageBox.Show("请输入数据库连接字符串");
            }
            else if (this.comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择数据库类型");
            }
            else
            {
                var connstr = this.textBox1.Text;
                //默认mssql
                SqlSugar.DbType dbtype = SqlSugar.DbType.SqlServer;

                if (this.comboBox1.SelectedItem == "MySQL")
                {
                    dbtype = SqlSugar.DbType.MySql;
                }
                else if (this.comboBox1.SelectedItem == "Oracle")
                {
                    dbtype = SqlSugar.DbType.Oracle;
                }

                ConnectionConfig config = new ConnectionConfig()
                {
                    ConnectionString = this.textBox1.Text,
                    DbType = dbtype,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.SystemTable
                };

                using (var db = new SqlSugarClient(config))
                {
                    var tablelist = db.DbMaintenance.GetTableInfoList();
                    this.ckbDtTabls.DataSource = tablelist;
                    this.ckbDtTabls.ValueMember = "Name";
                    this.ckbDtTabls.DisplayMember = "Description";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckAll_CheckStateChanged(object sender, EventArgs e)
        {

            if (ckAll.CheckState == CheckState.Checked)
            {
                for (int i = 0; i < ckbDtTabls.Items.Count; i++)
                {
                    ckbDtTabls.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < ckbDtTabls.Items.Count; i++)
                {
                    ckbDtTabls.SetItemChecked(i, false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.folderBrowserDialog1.SelectedPath.Trim() != "")
                    this.textBox2.Text = this.folderBrowserDialog1.SelectedPath.Trim();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if(this.textBox2.Text == ""){
            //    MessageBox.Show("请选择输出目录");
            //}else{

            //}
            try
            {


                List<string> tables = new List<string>();
                for (int i = 0; i < ckbDtTabls.CheckedItems.Count; i++)
                {
                    tables.Add(((SqlSugar.DbTableInfo)ckbDtTabls.CheckedItems[i]).Name);
                }
                string filepath = this.textBox2.Text;
                if (this.checkBox1.Checked)
                    filepath += "Models";
                sqlSugarModelGenera(this.textBox1.Text, filepath, this.textBox3.Text, tables.ToArray());
                MessageBox.Show("代码生成成功");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        private void sqlSugarModelGenera(string connectionStr, string filepath, string classNameSpace, string[] tables)
        {

            ConnectionConfig config = new ConnectionConfig()
            {
                ConnectionString = connectionStr, //必填
                DbType = SqlSugar.DbType.SqlServer, //必填
                IsAutoCloseConnection = true, //默认false
                InitKeyType = InitKeyType.SystemTable
            };

            using (var db = new SqlSugarClient(config))
            {
                //可以结合别名表，请看别名表的用法
                //db.SetMappingTables(mappingTableList);

                db.DbFirst.Where(tables).IsCreateDefaultValue().CreateClassFile(filepath, classNameSpace);
            }
        }
    }
}
