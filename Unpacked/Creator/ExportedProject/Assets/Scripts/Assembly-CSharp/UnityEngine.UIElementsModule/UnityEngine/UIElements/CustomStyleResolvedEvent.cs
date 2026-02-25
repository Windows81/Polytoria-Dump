namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Style (8))]
[Token(Token = "0x2000232")]
public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000233")]
	private sealed class <>c
	{
		[Token(Token = "0x40008BF")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C614E0", Offset = "0x1C606E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F50")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F51")]
		public <>c() { }

		[Address(RVA = "0x1C60430", Offset = "0x1C5F630", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000F52")]
		internal CustomStyleResolvedEvent <.cctor>b__0_0() { }

	}


	[Token(Token = "0x170002C8")]
	public ICustomStyle customStyle
	{
		[Address(RVA = "0x1C49F30", Offset = "0x1C49130", Length = "0x20")]
		[CalledBy(Type = typeof(BaseTreeView), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[Token(Token = "0x6000F4E")]
		 get { } //Length: 32
	}

	[Address(RVA = "0x1C49DF0", Offset = "0x1C48FF0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F4D")]
	private static CustomStyleResolvedEvent() { }

	[Address(RVA = "0x1C49ED0", Offset = "0x1C490D0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F4F")]
	public CustomStyleResolvedEvent() { }

	[Address(RVA = "0x1C49F30", Offset = "0x1C49130", Length = "0x20")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "OnInputCustomStyleResolved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomStyleResolvedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[Token(Token = "0x6000F4E")]
	public ICustomStyle get_customStyle() { }

}

