namespace RLD;

[Token(Token = "0x200007C")]
public interface IRTTransformGizmoListener
{

	[Token(Token = "0x600043A")]
	public bool OnCanBeTransformed(Gizmo transformGizmo) { }

	[Token(Token = "0x600043B")]
	public void OnTransformed(Gizmo transformGizmo) { }

}

