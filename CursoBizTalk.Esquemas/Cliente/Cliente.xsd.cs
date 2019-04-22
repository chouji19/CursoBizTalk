namespace CursoBizTalk.Esquemas.Cliente {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CursoBizTalk.Esquemas.Cliente",@"Cliente")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::CursoBizTalk.Esquemas.Cliente.TipoIdentificacion), XPath = @"/*[local-name()='Cliente' and namespace-uri()='http://CursoBizTalk.Esquemas.Cliente']/*[local-name()='Identificacion' and namespace-uri()='']/*[local-name()='TipoIdentificacion' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::CursoBizTalk.Esquemas.Cliente.NumeroIdentificacion), XPath = @"/*[local-name()='Cliente' and namespace-uri()='http://CursoBizTalk.Esquemas.Cliente']/*[local-name()='Identificacion' and namespace-uri()='']/*[local-name()='NumeroIdentificacion' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Cliente"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.Esquemas.Cliente.EsquemaPropiedades", typeof(global::CursoBizTalk.Esquemas.Cliente.EsquemaPropiedades))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.Esquemas.Cliente.PropertySchema", typeof(global::CursoBizTalk.Esquemas.Cliente.PropertySchema))]
    public sealed class Cliente : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CursoBizTalk.Esquemas.Cliente"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""https://CursoBizTalk.Esquemas.PropertySchema"" xmlns:ns0=""https://CursoBizTalk.Esquemas.EsquemaPropiedades"" targetNamespace=""http://CursoBizTalk.Esquemas.Cliente"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://CursoBizTalk.Esquemas.EsquemaPropiedades"" location=""CursoBizTalk.Esquemas.Cliente.EsquemaPropiedades"" />
        <b:namespace prefix=""ns1"" uri=""https://CursoBizTalk.Esquemas.PropertySchema"" location=""CursoBizTalk.Esquemas.Cliente.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Cliente"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:TipoIdentificacion"" xpath=""/*[local-name()='Cliente' and namespace-uri()='http://CursoBizTalk.Esquemas.Cliente']/*[local-name()='Identificacion' and namespace-uri()='']/*[local-name()='TipoIdentificacion' and namespace-uri()='']"" />
          <b:property name=""ns1:NumeroIdentificacion"" xpath=""/*[local-name()='Cliente' and namespace-uri()='http://CursoBizTalk.Esquemas.Cliente']/*[local-name()='Identificacion' and namespace-uri()='']/*[local-name()='NumeroIdentificacion' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Identificacion"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""NumeroIdentificacion"" type=""xs:string"" />
              <xs:element name=""TipoIdentificacion"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DatosBasicos"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Nombre"" type=""xs:string"" />
              <xs:element name=""Apellidos"" type=""xs:string"" />
              <xs:element name=""Nacionalidad"" type=""xs:string"" />
              <xs:element name=""Pais"" type=""xs:string"" />
              <xs:element name=""FechaNacimiento"" type=""xs:date"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Producto"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""IdProducto"" type=""xs:int"" />
              <xs:element name=""NombreDeProducto"" type=""xs:string"" />
              <xs:element name=""Valor"" type=""xs:decimal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Venta"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""TipoVenta"" type=""xs:string"" />
              <xs:element name=""FechaDeVenta"" type=""xs:dateTime"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Cliente() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Cliente";
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
