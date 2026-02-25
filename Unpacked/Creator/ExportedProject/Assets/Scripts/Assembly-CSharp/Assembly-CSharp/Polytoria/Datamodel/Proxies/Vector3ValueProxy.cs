namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003D1")]
public class Vector3ValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400101B")]
	private readonly Vector3Value vector3Value; //Field offset: 0x20

	[Token(Token = "0x17000C9E")]
	public Vector3 Value
	{
		[Address(RVA = "0x4B6410", Offset = "0x4B5610", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002989")]
		 get { } //Length: 47
		[Address(RVA = "0x4B6440", Offset = "0x4B5640", Length = "0x8F4")]
		[CallerCount(Count = 0)]
		[Calls(Type = "Polytoria.Controllers.GameIO+<LoadFromSite>d__13", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(XmlNode), Member = "get_Attributes", ReturnType = typeof(XmlAttributeList))]
		[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Int32&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = "U8Xml.Internal.ThrowHelper", Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RawString), Member = "FloatFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyHats>d__60", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.GameIO+<ModelFromSite>d__12", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.ImageCacheController+<LoadImage>d__12", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Vector3Value), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
		[Calls(Type = typeof(XmlNode), Member = "get_Children", ReturnType = typeof(XmlNodeList))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600298A")]
		 set { } //Length: 2292
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002988")]
	public Vector3ValueProxy(Vector3Value target) { }

	[Address(RVA = "0x4B6410", Offset = "0x4B5610", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002989")]
	public Vector3 get_Value() { }

	[Address(RVA = "0x4B6440", Offset = "0x4B5640", Length = "0x8F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_Children", ReturnType = typeof(XmlNodeList))]
	[Calls(Type = typeof(XmlNodeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TNodes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlNode>))]
	[Calls(Type = typeof(Vector3Value), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = "Polytoria.Controllers.ImageCacheController+<LoadImage>d__12", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "Polytoria.Controllers.GameIO+<ModelFromSite>d__12", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ApplyHats>d__60", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RawString), Member = "FloatFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = "U8Xml.Internal.ThrowHelper", Member = "ThrowInvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utf8Parser), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Int32&), typeof(Int32&), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "get_Attributes", ReturnType = typeof(XmlAttributeList))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(XmlAttributeEnumerableExtension), Member = "FindOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAttributes", typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(U8Xml.Option`1<U8Xml.XmlAttribute>))]
	[Calls(Type = "Polytoria.Controllers.GameIO+<LoadFromSite>d__13", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600298A")]
	public void set_Value(Vector3 value) { }

}

