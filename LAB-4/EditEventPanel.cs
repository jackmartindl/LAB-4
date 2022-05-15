using System;
using System.Windows.Forms;

namespace LAB_4;

public partial class EditEventPanel : Form
{
    private Event _selectedEvent;
    
    public EditEventPanel(Event selectedEvent)
    {
        InitializeComponent();
        Text = "Edycja wydarzenia";
        _selectedEvent = selectedEvent;
        
        eventName.Text = _selectedEvent.Name;
        agendaField.Text = _selectedEvent.Agenda;
        eventDate.Value = DateTime.Parse(_selectedEvent.Date);
    }

    private void editEventButton_Click(object sender, EventArgs e)
    {
        var dateOfEvent = eventDate.Value.Day + "-" + eventDate.Value.Month + "-" + eventDate.Value.Year;

        new DatabaseHandler().ChangeEventInformations(new Event(
            _selectedEvent.Id,
            eventName.Text,
            agendaField.Text,
            dateOfEvent));
    }
}