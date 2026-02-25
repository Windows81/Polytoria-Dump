namespace Battlehub.UIControls;

[Token(Token = "0x200002E")]
public class ListBox : ItemsControl<ItemDataBindingArgs>
{

	[Address(RVA = "0x5D0670", Offset = "0x5CF870", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ItemsControl`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000191")]
	public ListBox() { }

}

