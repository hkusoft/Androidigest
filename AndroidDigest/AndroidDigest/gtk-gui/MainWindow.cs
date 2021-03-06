
// This file has been generated by the GUI designer. Do not modify.
using Gtk;

public partial class MainWindow
{
	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow

		AddToolbarButtons();

		string title = "Androidigest: Quickly understand your android projects";

		this.Name = "Androidigest";
		this.Title = title;

		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}

		this.DefaultWidth = 800;
		this.DefaultHeight = 600;
		this.Show();

		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);

	
	}

	void AddToolbarButtons()
	{
		Toolbar toolbar = new Toolbar();
		toolbar.ToolbarStyle = ToolbarStyle.Icons;

		ToolButton opentb = new ToolButton(Stock.Open);
		ToolButton savetb = new ToolButton(Stock.Save);
		SeparatorToolItem sep = new SeparatorToolItem();
		ToolButton quittb = new ToolButton(Stock.Quit);

		toolbar.Insert(opentb, 0);
		toolbar.Insert(savetb, 1);
		toolbar.Insert(sep, 2);
		toolbar.Insert(quittb, 3);

		VBox vbox = new VBox(false, 2);
		vbox.PackStart(toolbar, false, false, 0);

		Add(vbox);
	}
}
