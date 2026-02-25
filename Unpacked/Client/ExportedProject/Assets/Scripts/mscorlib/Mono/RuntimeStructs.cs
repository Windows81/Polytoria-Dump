namespace Mono;

[Token(Token = "0x2000038")]
internal static class RuntimeStructs
{
	[Token(Token = "0x200003B")]
	public struct GenericParamInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000118")]
		internal MonoClass* pklass; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000119")]
		internal IntPtr name; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011A")]
		internal ushort flags; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400011B")]
		internal uint token; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011C")]
		internal MonoClass** constraints; //Field offset: 0x18

	}

	[Token(Token = "0x200003C")]
	public struct GPtrArray
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011D")]
		internal IntPtr* data; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400011E")]
		internal int len; //Field offset: 0x8

	}

	[Token(Token = "0x200003A")]
	public struct MonoClass
	{

	}

	[Token(Token = "0x2000039")]
	public struct RemoteClass
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000113")]
		internal IntPtr default_vtable; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000114")]
		internal IntPtr xdomain_vtable; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000115")]
		internal MonoClass* proxy_class; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000116")]
		internal IntPtr proxy_class_name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000117")]
		internal uint interface_count; //Field offset: 0x20

	}


}

