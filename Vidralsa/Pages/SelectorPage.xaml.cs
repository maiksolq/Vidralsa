namespace Vidralsa.Pages;

public partial class SelectorPage : ContentPage
{
	public SelectorPage()
	{
		InitializeComponent();

		GridCreator(120);
	}

	public void GridCreator(int items)
	{
		int rows = items / 4;

		for(int i = 0; i < rows; i++)
		{
			selectorGrid.AddRowDefinition(new RowDefinition());
		}

		for (int i = 0;i < rows; i++)
		{
            selectorGrid.Add(new Button
			{
				Text = $"Boton 0 {i}"
			}, 0, i);

            selectorGrid.Add(new Button
            {
                Text = $"Boton 1 {i}"
            }, 1, i);

            selectorGrid.Add(new Button
            {
                Text = $"Boton 2 {i}"
            }, 2, i);

            selectorGrid.Add(new Button
            {
                Text = $"Boton 3 {i}"
            }, 3, i);
        }
		
	}


}