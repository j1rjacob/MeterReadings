namespace TMF.Reports.UTIL
{
    public static class Paging
    {
        // Page
        //private static int _mintTotalRecords = 0;
        //private static int _mintPageSize = 0;
        //private static int _mintPageCount = 0;
        //private static int _mintCurrentPage = 1;
        
        //public static BindingSource FillGrid(DataGridView dgvMeterReading, ToolStripTextBox currentPage, ToolStripLabel pageCount)
        //{
        //    // For Page view.
        //    _mintPageSize = 20;
        //    _mintTotalRecords = GetCount();
        //    _mintPageCount = _mintTotalRecords / _mintPageSize;

        //    // Adjust page count if the last page contains partial page.
        //    if (_mintTotalRecords % _mintPageSize > 0)
        //        _mintPageCount++;

        //    _mintCurrentPage = 0;

        //    return LoadPage(dgvMeterReading, currentPage, pageCount);
        //}
        //public static int GetCount()
        //{
        //    int intCount = 0;
        //    using (SqlConnection connection =
        //        new SqlConnection(new SmartDB().Connection.ConnectionString))
        //    {
        //        connection.Open();
        //        // This select statement is very fast compare to SELECT COUNT(*)
        //        string strSql = "SELECT Rows FROM SYSINDEXES " +
        //                        "WHERE Id = OBJECT_ID('MeterReading') AND IndId < 2";

        //        SqlCommand cmd = connection.CreateCommand();
        //        cmd.CommandText = strSql;

        //        intCount = (int) cmd.ExecuteScalar();
        //        cmd.Dispose();
        //    }
        //    return intCount;
        //}
        //public static BindingSource LoadPage(DataGridView dgvMeterReading, ToolStripTextBox currentPage, ToolStripLabel pageCount)
        //{
        //    BindingSource source;
        //    string strSql = "";
        //    int intSkip = 0;

        //    intSkip = (_mintCurrentPage * _mintPageSize);
        //    SqlCommand cmd;
        //    SqlDataAdapter da;
        //    DataSet ds = new DataSet();
        //    using (SqlConnection connection =
        //        new SqlConnection(new SmartDB().Connection.ConnectionString))
        //    {
        //       //Select only the n records.
        //       strSql = "SELECT TOP " + _mintPageSize +
        //                " * FROM MeterReading WHERE Id NOT IN " +
        //                "(SELECT TOP " + intSkip + " Id FROM MeterReading)";
        //        //strSql = "SELECT * FROM MeterReading";

        //        cmd = connection.CreateCommand();
        //        cmd.CommandText = strSql;
        //        da = new SqlDataAdapter(cmd);
        //        da.Fill(ds, "MeterReading");

        //        // Populate Data Grid
        //        source = new BindingSource(ds.Tables["MeterReading"].DefaultView, null);
        //        dgvMeterReading.DataSource = source;

        //        // Show Status
        //        currentPage.Text = (_mintCurrentPage + 1).ToString();
        //        pageCount.Text = $"of {_mintPageCount}";
        //    //lblStatus.Text = (_mintCurrentPage + 1).ToString() +
        //    //                      " / " + _mintPageCount.ToString();

        //    cmd.Dispose();
        //    da.Dispose();
        //    ds.Dispose();
        //    }
        //    return source;
        //}
        //public static BindingSource GoFirst(DataGridView dgvMeterReading, ToolStripTextBox currentPage, ToolStripLabel pageCount)
        //{
        //    _mintCurrentPage = 0;
        //    return LoadPage(dgvMeterReading, currentPage, pageCount);
        //}
        //public static BindingSource GoPrevious(DataGridView dgvMeterReading, ToolStripTextBox currentPage, ToolStripLabel pageCount)
        //{
        //    if (_mintCurrentPage == _mintPageCount)
        //        _mintCurrentPage = _mintPageCount - 1;

        //    _mintCurrentPage--;

        //    if (_mintCurrentPage < 1)
        //        _mintCurrentPage = 0;

        //    return LoadPage(dgvMeterReading, currentPage, pageCount);
        //}
        //public static BindingSource GoNext(DataGridView dgvMeterReading, ToolStripTextBox currentPage, ToolStripLabel pageCount)
        //{
        //    _mintCurrentPage++;

        //    if (_mintCurrentPage > (_mintPageCount - 1))
        //        _mintCurrentPage = _mintPageCount - 1;

        //    return LoadPage(dgvMeterReading, currentPage, pageCount);
        //}
        //public static BindingSource GoLast(DataGridView dgvMeterReading, ToolStripTextBox currentPage, ToolStripLabel pageCount)
        //{
        //    _mintCurrentPage = _mintPageCount - 1;
        //    return LoadPage(dgvMeterReading, currentPage, pageCount);
        //}
    }
}
