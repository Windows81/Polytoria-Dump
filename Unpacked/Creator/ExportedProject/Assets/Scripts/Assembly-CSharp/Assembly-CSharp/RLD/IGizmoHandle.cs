namespace RLD;

[Token(Token = "0x200007B")]
public interface IGizmoHandle
{

	[Token(Token = "0x17000140")]
	public IGizmoDragSession DragSession
	{
		[Token(Token = "0x600040C")]
		 get { } //Length: 0
		[Token(Token = "0x600040D")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000141")]
	public Priority GenericHoverPriority
	{
		[Token(Token = "0x600040E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700013F")]
	public Gizmo Gizmo
	{
		[Token(Token = "0x600040B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000147")]
	public bool Has2DShapes
	{
		[Token(Token = "0x6000414")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000146")]
	public bool Has3DShapes
	{
		[Token(Token = "0x6000413")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000142")]
	public Priority HoverPriority2D
	{
		[Token(Token = "0x600040F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000143")]
	public Priority HoverPriority3D
	{
		[Token(Token = "0x6000410")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700013E")]
	public int Id
	{
		[Token(Token = "0x600040A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000148")]
	public bool Is2DHoverable
	{
		[Token(Token = "0x6000415")]
		 get { } //Length: 0
		[Token(Token = "0x6000416")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700014A")]
	public bool Is2DVisible
	{
		[Token(Token = "0x6000419")]
		 get { } //Length: 0
		[Token(Token = "0x600041A")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000149")]
	public bool Is3DHoverable
	{
		[Token(Token = "0x6000417")]
		 get { } //Length: 0
		[Token(Token = "0x6000418")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700014B")]
	public bool Is3DVisible
	{
		[Token(Token = "0x600041B")]
		 get { } //Length: 0
		[Token(Token = "0x600041C")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000145")]
	public int Num2DShapes
	{
		[Token(Token = "0x6000412")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000144")]
	public int Num3DShapes
	{
		[Token(Token = "0x6000411")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600042E")]
	public int Add2DShape(Shape2D shape) { }

	[Token(Token = "0x600042D")]
	public int Add3DShape(Shape3D shape) { }

	[Token(Token = "0x600042C")]
	public bool Contains2DShape(Shape2D shape) { }

	[Token(Token = "0x600042B")]
	public bool Contains3DShape(Shape3D shape) { }

	[Token(Token = "0x600040C")]
	public IGizmoDragSession get_DragSession() { }

	[Token(Token = "0x600040E")]
	public Priority get_GenericHoverPriority() { }

	[Token(Token = "0x600040B")]
	public Gizmo get_Gizmo() { }

	[Token(Token = "0x6000414")]
	public bool get_Has2DShapes() { }

	[Token(Token = "0x6000413")]
	public bool get_Has3DShapes() { }

	[Token(Token = "0x600040F")]
	public Priority get_HoverPriority2D() { }

	[Token(Token = "0x6000410")]
	public Priority get_HoverPriority3D() { }

	[Token(Token = "0x600040A")]
	public int get_Id() { }

	[Token(Token = "0x6000415")]
	public bool get_Is2DHoverable() { }

	[Token(Token = "0x6000419")]
	public bool get_Is2DVisible() { }

	[Token(Token = "0x6000417")]
	public bool get_Is3DHoverable() { }

	[Token(Token = "0x600041B")]
	public bool get_Is3DVisible() { }

	[Token(Token = "0x6000412")]
	public int get_Num2DShapes() { }

	[Token(Token = "0x6000411")]
	public int get_Num3DShapes() { }

	[Token(Token = "0x6000422")]
	public Shape2D Get2DShape(int shapeIndex) { }

	[Token(Token = "0x6000421")]
	public Shape3D Get3DShape(int shapeIndex) { }

	[Token(Token = "0x6000439")]
	public GizmoHandleHoverData GetHoverData(Ray hoverRay) { }

	[Token(Token = "0x600041D")]
	public float GetZoomFactor(Camera camera) { }

	[Token(Token = "0x600042A")]
	public bool Is2DShapeVisible(int shapeIndex) { }

	[Token(Token = "0x6000429")]
	public bool Is3DShapeVisible(int shapeIndex) { }

	[Token(Token = "0x6000430")]
	public void Remove2DShape(Shape2D shape) { }

	[Token(Token = "0x600042F")]
	public void Remove3DShape(Shape3D shape) { }

	[Token(Token = "0x6000437")]
	public void Render2DSolid(Camera camera, int shapeIndex) { }

	[Token(Token = "0x6000435")]
	public void Render2DSolid(Camera camera) { }

	[Token(Token = "0x6000436")]
	public void Render2DWire(Camera camera) { }

	[Token(Token = "0x6000438")]
	public void Render2DWire(Camera camera, int shapeIndex) { }

	[Token(Token = "0x6000433")]
	public void Render3DSolid(int shapeIndex) { }

	[Token(Token = "0x6000431")]
	public void Render3DSolid() { }

	[Token(Token = "0x6000434")]
	public void Render3DWire(int shapeIndex) { }

	[Token(Token = "0x6000432")]
	public void Render3DWire() { }

	[Token(Token = "0x600040D")]
	public void set_DragSession(IGizmoDragSession value) { }

	[Token(Token = "0x6000416")]
	public void set_Is2DHoverable(bool value) { }

	[Token(Token = "0x600041A")]
	public void set_Is2DVisible(bool value) { }

	[Token(Token = "0x6000418")]
	public void set_Is3DHoverable(bool value) { }

	[Token(Token = "0x600041C")]
	public void set_Is3DVisible(bool value) { }

	[Token(Token = "0x6000428")]
	public void Set2DShapeHoverable(int shapeIndex, bool isHoverable) { }

	[Token(Token = "0x6000427")]
	public void Set2DShapeVisible(int shapeIndex, bool isVisible) { }

	[Token(Token = "0x6000425")]
	public void Set3DShapeHoverable(int shapeIndex, bool isHoverable) { }

	[Token(Token = "0x6000424")]
	public void Set3DShapeVisible(int shapeIndex, bool isVisible) { }

	[Token(Token = "0x6000426")]
	public void SetAll2DShapesVisible(bool visible) { }

	[Token(Token = "0x6000423")]
	public void SetAll3DShapesVisible(bool visible) { }

	[Token(Token = "0x600041F")]
	public void SetHoverable(bool isHoverable) { }

	[Token(Token = "0x6000420")]
	public void SetVisible(bool isVisible) { }

	[Token(Token = "0x600041E")]
	public void SetZoomFactorTransform(GizmoTransform transform) { }

}

