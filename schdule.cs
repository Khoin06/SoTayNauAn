using SoTayNauAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoTayNauAn
{
    public partial class schdule : Form
    {


        public schdule()
        {
            InitializeComponent();

            LoadAccountList();
        }
       void LoadAccountList()
{
    string query = @"
        SELECT 
           CASE DATEPART(WEEKDAY, NgayTao)
              WHEN 2 THEN 'Monday'
              WHEN 3 THEN 'Tuesday'
              WHEN 4 THEN 'Wednesday'
              WHEN 5 THEN 'Thursday'
              WHEN 6 THEN 'Friday'
              WHEN 7 THEN 'Saturday'
              WHEN 1 THEN 'Sunday'
           END AS DayOfWeek,
           TenMenu
        FROM ChitietM";

    dataProvider data = new dataProvider();
    DataTable table = data.ExecuteQuery(query);

    // Đổ dữ liệu vào từng cột tương ứng với ngày trong tuần
    foreach (DataRow row in table.Rows)
    {
        string day = row["DayOfWeek"].ToString();
        string tenMenu = row["TenMenu"].ToString();

        // Xác định cột nào tương ứng với ngày
        int columnIndex = GetDayColumnIndex(day);

        // Thêm dữ liệu vào cột tương ứng
        scheduleGridView.Rows[0].Cells[columnIndex].Value = tenMenu;
    }
}

// Hàm chuyển ngày thành index cột
int GetDayColumnIndex(string day)
{
    switch (day)
    {
        case "Monday": return 0;
        case "Tuesday": return 1;
        case "Wednesday": return 2;
        case "Thursday": return 3;
        case "Friday": return 4;
        case "Saturday": return 5;
        case "Sunday": return 6;
        default: return -1;
    }
}



    }
}
