using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using Commode;

public class Form_Test : Form
{
	static public void Main ()
    {
        Application.Run (new Form_Test());
    }

    public Form_Test()
    {
		try
		{
			ConvertDatabase convDb = new ConvertDatabase("db.accdb");

		    init();

			this.Controls["lblPath"].Text = "Path Access Database: " + convDb.accessDatabasePathFile;
		
			this.Controls["lblName"].Text = "Name Access Database: " + convDb.accessDatabaseNameFile;		
			this.Controls["lblCompleteName"].Text = "Complete Name Access Database: " + convDb.accessDatabaseCompleteNameFile; 

			convDb.atom();
		}
		catch(Exception e)
		{
			MessageBox.Show(e.Message);
		}	
	}

	public void init()
	{
		
		this.Text = "Commode Dll Test";
		this.AutoSize = true;

		Label lblPath = new Label();
		lblPath.Name = "lblPath";
		lblPath.Location = new Point(13, 13);
		lblPath.AutoSize = true;
		this.Controls.Add(lblPath);

		Label lblName = new Label();
		lblName.Name = "lblName";
		lblName.Location = new Point(13, 30);
		lblName.AutoSize = true;
		this.Controls.Add(lblName);

		Label lblCompleteName = new Label();
		lblCompleteName.Name = "lblCompleteName";
		lblCompleteName.Location = new Point(13, 47);
		lblCompleteName.AutoSize = true;
		this.Controls.Add(lblCompleteName);
	}
}
