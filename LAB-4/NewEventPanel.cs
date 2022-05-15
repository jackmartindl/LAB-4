using System;
using System.Windows.Forms;

namespace LAB_4;

public partial class NewEventPanel : Form
{
    public NewEventPanel()
    {
        InitializeComponent();
        Text = "Nowe wydarzenie";
    }

    private void createEventButton_Click(object sender, EventArgs e)
    {
        var dateOfEvent = eventDate.Value.Day + "-" + eventDate.Value.Month + "-" + eventDate.Value.Year;
        var newEvent = new Event(
            0,
            eventName.Text,
            agendaField.Text,
            dateOfEvent);
        
        new DatabaseHandler().AddEvent(newEvent);
        
    }
}