namespace UnityEngine.UIElements;

[Token(Token = "0x20002EF")]
public interface ICustomStyle
{

	[Token(Token = "0x6001501")]
	public bool TryGetValue(CustomStyleProperty<Single> property, out float value) { }

	[Token(Token = "0x6001502")]
	public bool TryGetValue(CustomStyleProperty<Int32> property, out int value) { }

	[Token(Token = "0x6001503")]
	public bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

	[Token(Token = "0x6001504")]
	public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

	[Token(Token = "0x6001505")]
	public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

	[Token(Token = "0x6001506")]
	public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

	[Token(Token = "0x6001507")]
	public bool TryGetValue(CustomStyleProperty<String> property, out string value) { }

}

