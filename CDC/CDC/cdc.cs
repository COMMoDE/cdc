using System;
using System.Reflection;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Commode
{
	public class ConvertDatabase
	{
		//fields
		private string _accessDatabasePathFile; //define the path of the access database file
		private string _accessDatabaseNameFile; //define the name of the access database file
		private string _accessDatabaseCompleteNameFile; //contains path and name of the access database file

		//properties
		public string accessDatabasePathFile //this property controls the incoming values
		{
			set
			{
				if(value is string) //if the incoming value is a string
				{
					_accessDatabasePathFile = value; //sets the interested field to "value"
					setAccessDatabaseCompleteNameFile(this._accessDatabasePathFile, this._accessDatabaseNameFile); //update				
				}				
				else
					throw new Exception("ERROR: The value inserted is not a string"); //otherwise throws an exception
			}
			get
			{
				return(_accessDatabasePathFile); //there are no controls to get the field value
			}
		}
		public string accessDatabaseNameFile //this property controls the incoming values
		{
			set
			{
				if(value is string) //if the incoming value is a string
				{
					_accessDatabaseNameFile = value; //sets the interested field to "value"
					setAccessDatabaseCompleteNameFile(this._accessDatabasePathFile, this._accessDatabaseNameFile); //update
				}				
				else
					throw new Exception("ERROR: The value inserted is not a string"); //otherwise throws an exception
			}
			get
			{
				return(_accessDatabaseNameFile); //there are no controls to get the field value
			}
		}
		public string accessDatabaseCompleteNameFile
		{
			get
			{
				if(File.Exists(this._accessDatabaseCompleteNameFile)) //check if the file exists
					return(this._accessDatabaseCompleteNameFile);
				else
					throw new Exception("ERROR: the file doesn't exists"); //if the file doesn't exists throw an exception
			}
		}

		//constructors
		public ConvertDatabase()
		{
			this.accessDatabasePathFile = Path.GetDirectoryName(Application.ExecutablePath); //set the path of the current directory
			this.accessDatabaseNameFile = string.Empty; //if it's not specified, we cannot know the name of the file	
		}
		public ConvertDatabase(string accessDatabaseNameFile) : this()
		{
			this.accessDatabaseNameFile = accessDatabaseNameFile;
		}
		public ConvertDatabase(string accessDatabasePathFile, string accessDatabaseNameFile)
		{
			this.accessDatabasePathFile = accessDatabasePathFile;
			this.accessDatabaseNameFile = accessDatabaseNameFile;
		}

		//"setAccessDatabasePathFile" and "setAccessDatabaseNameFile" accessors methods
		public void setAccessDatabasePathFile(string accessDatabasePathFile) //simple "accessDatabasePathFile" set method
		{
			this.accessDatabasePathFile = accessDatabasePathFile;
			setAccessDatabaseCompleteNameFile(this.accessDatabasePathFile,this.accessDatabaseNameFile);
		}
		public string getAccessDatabasePathFile() //simple "accessDatabasePathFile" get method
		{
			return(this.accessDatabasePathFile);
		}
		public void setAccessDatabaseNameFile(string accessDatabaseNameFile) //simple "accessDatabaseNameFile" set method
		{
			this.accessDatabaseNameFile = accessDatabaseNameFile;
			setAccessDatabaseCompleteNameFile(this.accessDatabasePathFile,this.accessDatabaseNameFile);
		}
		public string getAccessDatabaseNameFile() //simple "accessDatabaseNameFile" get method
		{
			return(this.accessDatabaseNameFile);
		}

		//"accessDatabaseCompleteNameFile" (path + file) set method
		public void setAccessDatabaseCompleteNameFile(string accessDatabasePathFile, string accessDatabaseNameFile)
		{
			this._accessDatabaseCompleteNameFile = accessDatabasePathFile + "/" + accessDatabaseNameFile;		
		}
		//"accessDatabaseCompleteNameFile" (path + file) get method
		public string getAccessDatabaseCompleteNameFile()
		{
			return(accessDatabaseCompleteNameFile);
		}

		//conversion methods
		public string atom()
		{
			string sql;
			string connectionString;
			OleDbDataReader reader;
			OleDbConnection connection;	
			OleDbCommand command;		
			FileInfo extension = new FileInfo(getAccessDatabaseCompleteNameFile());

			if(string.Compare(extension.Extension, "mdb") == 0)	
				connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + getAccessDatabaseCompleteNameFile() + ";User Id=admin;Password=;";
			else
				connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + getAccessDatabaseCompleteNameFile() + ";Persist Security Info=False;";

			connection = new OleDbConnection(connectionString);
			
			connection.Open();
		
			if(string.Compare(extension.Extension, "mdb") == 0)
				sql = "SELECT MSysObjects.Name AS table_name FROM MSysObjects WHERE (((Left([Name],1))<>'~') AND ((Left([Name],4))<>'MSys') AND ((MSysObjects.Type) In (1,4,6))) order by MSysObjects.Name";
			else
				sql = "SELECT MSysObjects.Name AS table_name FROM MSysObjects WHERE (((Left([Name],1))<>'~') AND ((Left([Name],4))<>'MSys') AND ((MSysObjects.Type) In (1,4,6)) AND ((MSysObjects.Flags)=0)) order by MSysObjects.Name";
 
			command = new OleDbCommand(sql, connection);
			reader = command.ExecuteReader();

			while(reader.Read())
			{
				MessageBox.Show(reader[0].ToString());
			}

			connection.Close();

			return("work in progress");
		}

		//methods
		
	}
}


