namespace blalogin.Data
{
    internal class OleDbDataAdapter
    {
        private string strSql;
        private string strCSVConnString;

        public OleDbDataAdapter(string strSql, string strCSVConnString)
        {
            this.strSql = strSql;
            this.strCSVConnString = strCSVConnString;
        }
    }
}