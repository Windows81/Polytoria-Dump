namespace RLD;

[Token(Token = "0x200005A")]
public interface IGizmoBehaviour
{

	[Token(Token = "0x170000BF")]
	public Gizmo Gizmo
	{
		[Token(Token = "0x60002AF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C0")]
	public bool IsEnabled
	{
		[Token(Token = "0x60002B0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60002AF")]
	public Gizmo get_Gizmo() { }

	[Token(Token = "0x60002B0")]
	public bool get_IsEnabled() { }

	[Token(Token = "0x60002B1")]
	public void Init_SystemCall(GizmoBehaviorInitParams initParams) { }

	[Token(Token = "0x60002B3")]
	public void OnAttached() { }

	[Token(Token = "0x60002B4")]
	public void OnDetached() { }

	[Token(Token = "0x60002B6")]
	public void OnDisabled() { }

	[Token(Token = "0x60002B5")]
	public void OnEnabled() { }

	[Token(Token = "0x60002BB")]
	public void OnGizmoAttemptHandleDragBegin(int handleId) { }

	[Token(Token = "0x60002BA")]
	public bool OnGizmoCanBeginDrag(int handleId) { }

	[Token(Token = "0x60002B8")]
	public void OnGizmoDisabled() { }

	[Token(Token = "0x60002BE")]
	public void OnGizmoDragBegin(int handleId) { }

	[Token(Token = "0x60002C0")]
	public void OnGizmoDragEnd(int handleId) { }

	[Token(Token = "0x60002BF")]
	public void OnGizmoDragUpdate(int handleId) { }

	[Token(Token = "0x60002B7")]
	public void OnGizmoEnabled() { }

	[Token(Token = "0x60002B9")]
	public void OnGizmoHandlePicked(int handleId) { }

	[Token(Token = "0x60002BC")]
	public void OnGizmoHoverEnter(int handleId) { }

	[Token(Token = "0x60002BD")]
	public void OnGizmoHoverExit(int handleId) { }

	[Token(Token = "0x60002C4")]
	public void OnGizmoRender(Camera camera) { }

	[Token(Token = "0x60002C1")]
	public void OnGizmoUpdateBegin() { }

	[Token(Token = "0x60002C2")]
	public void OnGizmoUpdateEnd() { }

	[Token(Token = "0x60002C3")]
	public void OnGUI() { }

	[Token(Token = "0x60002B2")]
	public void SetEnabled(bool enabled) { }

}

