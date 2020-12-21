﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Table_Component
{
    public partial class Budget_Table : Form
    {
        public Budget_Table()
        {
            InitializeComponent();
        }

        private void Budget_Table_Load(object sender, EventArgs e)
        {
            string kn = "Server=DESKTOP-D36TE7P;Database=TEST; uid=sa;Password=0981097144";
            string cl = "SELECT * FROM ThuChi";
            SqlConnection con = new SqlConnection(kn);
            SqlCommand cm = new SqlCommand(cl, con);
            SqlDataAdapter ad = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            con.Open();
            Char_Fill("Months", ds);
            con.Close();
        }

        private void Char_Fill(string Loai, DataSet data)
        {
            this.chart_Budget.DataSource = data;
            switch(Loai)
            {
                case "Weeks":

                    break;
                case "Months":
                    //set data
                    this.chart_Budget.Series[0].XValueMember = "Thang";
                    this.chart_Budget.Series[0].YValueMembers = "Tien_thu";
                    this.chart_Budget.Series[1].XValueMember = "Thang";
                    this.chart_Budget.Series[1].YValueMembers = "Tien_Chi";
                    this.chart_Budget.Series[2].XValueMember = "thang";
                    this.chart_Budget.Series[2].YValueMembers = "Loi_Nhuan";
                    //secondary Axis
                    this.chart_Budget.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
                    this.chart_Budget.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                    this.chart_Budget.ChartAreas[0].AxisY2.IsStartedFromZero = this.chart_Budget.ChartAreas[0].AxisY.IsStartedFromZero;
                    this.chart_Budget.Series[2].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                    //set title
                    this.chart_Budget.ChartAreas[0].AxisX.Title = "Tháng";
                    this.chart_Budget.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
                    this.chart_Budget.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.chart_Budget.ChartAreas[0].AxisY.Title = "Thu Chi";
                    this.chart_Budget.ChartAreas[0].AxisY.TitleAlignment = System.Drawing.StringAlignment.Center;
                    this.chart_Budget.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.chart_Budget.ChartAreas[0].AxisY2.Title = "Lợi Nhuận";
                    this.chart_Budget.ChartAreas[0].AxisY2.TitleAlignment = System.Drawing.StringAlignment.Center;
                    this.chart_Budget.ChartAreas[0].AxisY2.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    break;
                case "Years":

                    break;
            }
        }
    }
}
