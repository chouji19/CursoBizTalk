namespace CursoBizTalk.Esquemas.ClienteJSON {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CursoBizTalk.Esquemas.ClienteJSON.JSONCliente",@"ClienteJSON")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ClienteJSON"})]
    public sealed class JSONCliente : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://CursoBizTalk.Esquemas.ClienteJSON.JSONCliente"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ClienteJSON"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""Cliente"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""Identificacion"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""NumeroIdentificacion"" type=""xs:unsignedInt"" />
                    <xs:element minOccurs=""0"" name=""TipoIdentificacion"" type=""xs:unsignedByte"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""DatosBasicos"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""Nombres"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Apellidos"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""idPais"" type=""xs:int"" />
                    <xs:element minOccurs=""0"" name=""Ciudad"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public JSONCliente() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ClienteJSON";
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
