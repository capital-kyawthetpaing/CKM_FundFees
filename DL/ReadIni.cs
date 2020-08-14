

namespace DL
{
    public class ReadIni
    {
        public string GetConnectionString()
        {
            string filePath = @"C:\DBConfig\DBConfig.ini";

            if (System.IO.File.Exists(filePath))
            {
                return GetInformationOfIniFile(filePath);
            }
            else
            {
                return "";
            }
        }

        private string GetInformationOfIniFile(string filePath)
        {
            IniFileReader ifd = new IniFileReader(filePath);

            return "Data Source=" + ifd.IniReadValue("Database", "CKMFC_FundManagement").Split(',')[0] +
                    ";Initial Catalog=" + ifd.IniReadValue("Database", "CKMFC_FundManagement").Split(',')[1] +
                    ";Persist Security Info=True;User ID=" + ifd.IniReadValue("Database", "CKMFC_FundManagement").Split(',')[2] +
                    ";Password=" + ifd.IniReadValue("Database", "CKMFC_FundManagement").Split(',')[3] +
                    ";";
        }
    }
}
