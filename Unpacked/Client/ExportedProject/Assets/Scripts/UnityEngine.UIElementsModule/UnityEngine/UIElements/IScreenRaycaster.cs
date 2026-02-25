namespace UnityEngine.UIElements;

[Token(Token = "0x2000273")]
internal interface IScreenRaycaster
{

	[Token(Token = "0x600112B")]
	public IEnumerable<ValueTuple`3<Ray, Camera, Boolean>> MakeRay(Vector2 mousePosition, int pointerId, Nullable<Int32> targetDisplay) { }

	[Token(Token = "0x600112A")]
	public void Update() { }

}

