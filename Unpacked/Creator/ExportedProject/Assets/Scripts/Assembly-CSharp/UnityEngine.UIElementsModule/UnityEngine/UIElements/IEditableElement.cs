namespace UnityEngine.UIElements;

[Token(Token = "0x20000E3")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IEditableElement
{

	[Token(Token = "0x17000101")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Action editingEnded
	{
		[Token(Token = "0x60006DD")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000100")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Action editingStarted
	{
		[Token(Token = "0x60006DC")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x60006DD")]
	internal Action get_editingEnded() { }

	[Token(Token = "0x60006DC")]
	internal Action get_editingStarted() { }

}

