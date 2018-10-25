using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;
using System.IO;

namespace GenerateSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string filePath = "";
        private void button2_Click(object sender, EventArgs e)
        {
            //选文件
            fileSelect.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //生成
            try
            {
                if (filePath.Length < 1)
                {
                    MessageBox.Show("请选择数据文件");
                    return;
                }
                Workbook book = new Workbook(filePath);
                Cells cells = book.Worksheets[0].Cells;
                DataTable dt = new DataTable();
                dt = cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
                if (dt.Rows.Count < 1)
                    return;
                string strSQL = "";
                string[] cols = txtCols.Text.Trim().Split(',');
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string insert = "INSERT " + txtTableName.Text + "(";
                    //固定列
                    foreach (string item in txtMCols.Text.Split(','))
                        insert += item + ",";
                    //字段
                    if (cols.Length > 1)
                        foreach (string item in cols)
                            insert += item + ",";
                    else
                        for (int j = 0; j < dt.Columns.Count; j++)
                            insert += dt.Columns[j].ColumnName + ",";
                    insert = insert.Substring(0, insert.Length - 1);
                    insert += ") VALUES(";
                    //固定值
                    foreach (string item in txtMValue.Text.Split(','))
                        insert += "'" + ToStr(item) + "'" + ",";
                    //值
                    for (int j = 0; j < dt.Columns.Count; j++)
                        if (ckNull.Checked)
                            insert += (ToStr(dt.Rows[i][j]) == "" ? "null" : "'" + ToStr(dt.Rows[i][j]) + "'") + ",";
                        else
                            insert += "'" + ToStr(dt.Rows[i][j]) + "'" + ",";
                    insert = insert.Substring(0, insert.Length - 1);
                    insert += ") \n";
                    strSQL += insert;
                }
                txtSQL.Text = strSQL;
            }
            catch (Exception ex)
            {
                txtSQL.Text = ex.Message;
            }
        }
        private string ToStr(object obj)
        {
            if (obj == null)
                return "";
            return obj.ToString().Trim().Replace("'", "''");
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(fileSelect.FileName))
                filePath = fileSelect.FileName;
            txtFileName.Text = fileSelect.FileName;
        }
    }
}
