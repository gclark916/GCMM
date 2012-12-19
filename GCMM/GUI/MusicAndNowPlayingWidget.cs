using System;

namespace GCMM
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class MusicAndNowPlayingWidget : Gtk.Bin
	{
		
		private int hpanedPosition;
		
		public MusicAndNowPlayingWidget ()
		{
			this.Build ();
			this.hpanedPosition = this.hpaned.Position;
		}
		
		//TODO: subclass HPaned and override OnSizeAllocate
		/*protected override void OnSizeAllocated(Gdk.Rectangle allocation)
		{
			int currentWidth = this.Allocation.Width;
			int widthDiff = allocation.Width - currentWidth;
			int origPosition = this.hpaned.Position;
			//base.OnSizeAllocated(allocation);
			if (origPosition + widthDiff < allocation.Width)
			{
				this.hpanedPosition = this.hpanedPosition + widthDiff;
				this.hpaned.Position =this.hpanedPosition;
				//int newPosition = origPosition + widthDiff;
				//this.hpaned.Position = newPosition;
				
				//Gdk.Rectangle r1 = this.hpaned.Child1.Allocation;
				//Gdk.Rectangle newR1 = new Gdk.Rectangle(allocation.X, allocation.Y, r1.Width + widthDiff, allocation.Height);
				//Gdk.Rectangle r2 = this.hpaned.Child2.Allocation;
				//Gdk.Rectangle newR2 = new Gdk.Rectangle(allocation.X + r1.Width + widthDiff, allocation.Y, r2.Width, allocation.Height);
				//this.hpaned.SizeAllocate(allocation);
				//this.hpaned.Child1.SizeAllocate(newR1);
				//this.hpaned.Child2.SizeAllocate(newR2);
			}
			//this.hpaned.Position = origPosition + widthDiff;
			//this.hpaned.Child1.SetSizeRequest(origWidth + widthDiff, this.hpaned.Child1.SizeRequest().Height);
			//this.hpaned.Child1.QueueResize();
		}*/
	}
}

