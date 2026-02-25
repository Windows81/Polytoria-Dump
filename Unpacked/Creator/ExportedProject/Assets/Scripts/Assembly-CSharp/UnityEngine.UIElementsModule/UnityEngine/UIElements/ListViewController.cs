namespace UnityEngine.UIElements;

[Token(Token = "0x200005B")]
public class ListViewController : BaseListViewController
{

	[Token(Token = "0x17000066")]
	protected ListView listView
	{
		[Address(RVA = "0x1AC8890", Offset = "0x1AC7A90", Length = "0x72")]
		[CalledBy(Type = typeof(ListViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(ListViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000314")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000319")]
	public ListViewController() { }

	[Address(RVA = "0x1AC84A0", Offset = "0x1AC76A0", Length = "0x24D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000316")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x1AC86F0", Offset = "0x1AC78F0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000318")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x1AC8890", Offset = "0x1AC7A90", Length = "0x72")]
	[CalledBy(Type = typeof(ListViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(ListViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000314")]
	protected ListView get_listView() { }

	[Address(RVA = "0x1AC8740", Offset = "0x1AC7940", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000315")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x1AC8840", Offset = "0x1AC7A40", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListViewController), Member = "get_listView", ReturnType = typeof(ListView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000317")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

