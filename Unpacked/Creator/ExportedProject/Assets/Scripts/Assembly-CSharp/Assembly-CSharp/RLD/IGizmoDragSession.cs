namespace RLD;

[Token(Token = "0x2000056")]
public interface IGizmoDragSession
{

	[Token(Token = "0x170000B5")]
	public GizmoDragChannel DragChannel
	{
		[Token(Token = "0x600027E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B4")]
	public bool IsActive
	{
		[Token(Token = "0x600027D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B9")]
	public Vector3 RelativeDragOffset
	{
		[Token(Token = "0x6000282")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BA")]
	public Quaternion RelativeDragRotation
	{
		[Token(Token = "0x6000283")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BB")]
	public Vector3 RelativeDragScale
	{
		[Token(Token = "0x6000284")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B6")]
	public Vector3 TotalDragOffset
	{
		[Token(Token = "0x600027F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B7")]
	public Quaternion TotalDragRotation
	{
		[Token(Token = "0x6000280")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B8")]
	public Vector3 TotalDragScale
	{
		[Token(Token = "0x6000281")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000286")]
	public void AddTargetTransform(GizmoTransform transform) { }

	[Token(Token = "0x6000288")]
	public bool Begin() { }

	[Token(Token = "0x6000285")]
	public bool ContainsTargetTransform(GizmoTransform transform) { }

	[Token(Token = "0x600028A")]
	public void End() { }

	[Token(Token = "0x600027E")]
	public GizmoDragChannel get_DragChannel() { }

	[Token(Token = "0x600027D")]
	public bool get_IsActive() { }

	[Token(Token = "0x6000282")]
	public Vector3 get_RelativeDragOffset() { }

	[Token(Token = "0x6000283")]
	public Quaternion get_RelativeDragRotation() { }

	[Token(Token = "0x6000284")]
	public Vector3 get_RelativeDragScale() { }

	[Token(Token = "0x600027F")]
	public Vector3 get_TotalDragOffset() { }

	[Token(Token = "0x6000280")]
	public Quaternion get_TotalDragRotation() { }

	[Token(Token = "0x6000281")]
	public Vector3 get_TotalDragScale() { }

	[Token(Token = "0x6000287")]
	public void RemoveTargetTransform(GizmoTransform transform) { }

	[Token(Token = "0x6000289")]
	public bool Update() { }

}

