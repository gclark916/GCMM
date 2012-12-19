using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnConfigureEvent (object sender, ConfigureEventArgs a)
	{
		Widget[] children = this.Children;
		foreach (Widget child in children) {
			Console.WriteLine(child.Name);
		}
	}
}
