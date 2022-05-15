using System;
using System.Windows.Forms;

namespace LAB_4;

public partial class AdminPanel : Form
{
    public AdminPanel()
    {
        InitializeComponent();
        Text = "Panel administratora";
    }

    private void usersConfigButton_Click(object sender, EventArgs e)
    {
        new UserManagementPanel().Show();
    }

    private void eventConfigButton_Click(object sender, EventArgs e)
    {
        new EventManagementPanel().Show();
    }

    private void entryConfigButton_Click(object sender, EventArgs e)
    {
        new UsersEntriesManagement().Show();
    }
}