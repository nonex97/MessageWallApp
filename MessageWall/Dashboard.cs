using System.ComponentModel;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();

            WireUpLists(); // call after initializing components
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages;
        }

        private void AddMessage_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.",
                    "Blank Message Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }

            messageText.Focus();
        }
    }
}
