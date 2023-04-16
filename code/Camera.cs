namespace Graphicator;

public class Camera
{
	private static readonly Rect ReferenceViewport = new Rect( 0, 0, 1920, 1080 );
	public Rect Viewport = new Rect( 0, 0, 1920, 1080 );
}

public enum CameraAlignment
{
	/// <summary> 0,0 of the actor == top left of the camera virtual viewport </summary>
	TopLeft,

	/// <summary> 0,0 of the actor == middle of the camera virtual viewport </summary>
	Center
}
