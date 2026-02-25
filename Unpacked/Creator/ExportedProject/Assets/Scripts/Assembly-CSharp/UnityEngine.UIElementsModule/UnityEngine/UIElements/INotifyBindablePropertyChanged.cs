namespace UnityEngine.UIElements;

[Token(Token = "0x2000045")]
public interface INotifyBindablePropertyChanged
{

	[Token(Token = "0x14000001")]
	public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6000204")]
		 add { } //Length: 0
		[CompilerGenerated]
		[Token(Token = "0x6000205")]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	[Token(Token = "0x6000204")]
	public void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[CompilerGenerated]
	[Token(Token = "0x6000205")]
	public void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

}

