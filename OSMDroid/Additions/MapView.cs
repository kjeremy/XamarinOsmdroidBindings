using Android.Graphics;
using Android.Locations;

namespace OsmDroid.Views
{
    public partial class MapView
    {
        // TODO: Pretty sure there's a way to manipulate Metadata.xml to
        // do this for us.
        public void SetBackgroundColor(int color)
        {
            this.SetBackgroundColor(new Color(color));
        }
    }
}

namespace OsmDroid.Views.Overlay
{
    public partial class MyLocationOverlay
    {
        public void OnStatusChanged(string provider, int status, Android.OS.Bundle extras)
        {
            this.OnStatusChanged(provider, (Availability)status, extras);
        }
    }
}