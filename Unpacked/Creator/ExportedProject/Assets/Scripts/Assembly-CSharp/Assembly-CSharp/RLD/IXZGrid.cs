namespace RLD;

[Token(Token = "0x2000203")]
public interface IXZGrid
{

	[Token(Token = "0x17000639")]
	public Matrix4x4 WorldMatrix
	{
		[Token(Token = "0x60013BC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000638")]
	public Plane WorldPlane
	{
		[Token(Token = "0x60013BB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60013BD")]
	public XZGridCell CellFromWorldPoint(Vector3 worldPoint) { }

	[Token(Token = "0x60013BC")]
	public Matrix4x4 get_WorldMatrix() { }

	[Token(Token = "0x60013BB")]
	public Plane get_WorldPlane() { }

	[Token(Token = "0x60013BE")]
	public bool Raycast(Ray ray, out float t) { }

}

