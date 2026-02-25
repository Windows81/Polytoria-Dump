namespace RLD;

[Token(Token = "0x2000091")]
public interface ISceneGizmo
{

	[Token(Token = "0x1700018E")]
	public Gizmo OwnerGizmo
	{
		[Token(Token = "0x6000529")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700018F")]
	public Camera SceneCamera
	{
		[Token(Token = "0x600052A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000529")]
	public Gizmo get_OwnerGizmo() { }

	[Token(Token = "0x600052A")]
	public Camera get_SceneCamera() { }

}

