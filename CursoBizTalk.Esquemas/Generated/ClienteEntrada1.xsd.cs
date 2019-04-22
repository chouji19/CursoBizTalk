namespace CursoBizTalk.Esquemas.Generated {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"ClienteData")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ClienteData"})]
    public sealed class ClienteEntrada1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ClienteData"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Tipo"" type=""xs:unsignedByte"" />
        <xs:element name=""numero"" type=""xs:unsignedInt"" />
        <xs:element name=""nombres"" type=""xs:string"" />
        <xs:element name=""apellido"" type=""xs:string"" />
        <xs:element name=""pais"" type=""xs:unsignedByte"" />
        <xs:element name=""Depto"" type=""xs:unsignedByte"" />
        <xs:element name=""Ciudad"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ClienteEntrada1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ClienteData";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
