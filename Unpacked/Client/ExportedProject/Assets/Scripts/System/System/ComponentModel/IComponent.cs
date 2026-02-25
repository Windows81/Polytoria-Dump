namespace System.ComponentModel;

[ComVisible(True)]
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", True)]
[Token(Token = "0x2000186")]
[TypeConverter(typeof(ComponentConverter))]
public interface IComponent : IDisposable
{

	[Token(Token = "0x170001C2")]
	public ISite Site
	{
		[Token(Token = "0x600095D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600095D")]
	public ISite get_Site() { }

}

