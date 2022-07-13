namespace LogicalModel;

public partial class LogicalPage : ContentPage
{
	public LogicalPage()
	{
		InitializeComponent();
	}

	private void EvaluateBool(object sender, EventArgs args)
	{
		try
		{
            Button button = (Button)sender;

            if (button.Text == "True")
            {
                button.Text = "False";
				button.SetDynamicResource(BackgroundColorProperty, "OffState");
            }
            else
            {
                button.Text = "True";
                button.SetDynamicResource(BackgroundColorProperty, "OnState");
            }
        }
		catch(InvalidCastException ex)
		{

		}

		if(operatorPicker.SelectedItem == null)
			return;

		string selected0 = operatorPicker.SelectedItem.ToString();

		if (selected0 == "AND")
			resultLabel.Text = (leftButton.Text == "True" && rightButton.Text == "True").ToString();
		else if(selected0 == "OR")
            resultLabel.Text = (leftButton.Text == "True" || rightButton.Text == "True").ToString();
        else if (selected0 == "XOR")
            resultLabel.Text = (leftButton.Text == "True" ^ rightButton.Text == "True").ToString();

		if (resultLabel.Text == "True")
			resultLabel.SetDynamicResource(BackgroundColorProperty, "OnState");
		else
            resultLabel.SetDynamicResource(BackgroundColorProperty, "OffState");


    }
}