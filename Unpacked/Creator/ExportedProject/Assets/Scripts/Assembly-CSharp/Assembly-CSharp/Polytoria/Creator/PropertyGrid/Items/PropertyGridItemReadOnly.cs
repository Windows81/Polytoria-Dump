namespace Polytoria.Creator.PropertyGrid.Items;

[Token(Token = "0x20003E7")]
public class PropertyGridItemReadOnly : PropertyGridItem
{

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A1B")]
	public PropertyGridItemReadOnly() { }

	[Address(RVA = "0x4AB1F0", Offset = "0x4AA3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyGridItem), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002A19")]
	public virtual void SetProperty(PropertyInfo property) { }

	[Address(RVA = "0x4AB200", Offset = "0x4AA400", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002A1A")]
	public virtual void SetValue(object value) { }

}

