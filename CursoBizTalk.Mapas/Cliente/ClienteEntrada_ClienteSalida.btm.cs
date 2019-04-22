namespace CursoBizTalk.Mapas.Cliente {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.Esquemas.Cliente.Cliente", typeof(global::CursoBizTalk.Esquemas.Cliente.Cliente))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.Esquemas.Cliente.ClienteSalida", typeof(global::CursoBizTalk.Esquemas.Cliente.ClienteSalida))]
    public sealed class ClienteEntrada_ClienteSalida : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""http://CursoBizTalk.Esquemas.Cliente"" xmlns:ns0=""http://CursoBizTalk.Esquemas.Cliente.ClienteSalida"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Cliente"" />
  </xsl:template>
  <xsl:template match=""/s0:Cliente"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(Venta/TipoVenta/text()) , &quot;1&quot;)"" />
    <xsl:variable name=""var:v5"" select=""&quot;&quot;"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(string(DatosBasicos/Nombre/text()) , &quot; &quot; , string(DatosBasicos/Apellidos/text()))"" />
    <xsl:variable name=""var:v10"" select=""count(/s0:Cliente/Producto)"" />
    <ns0:ClienteSalida>
      <Proceso>
        <FechaTransaccion>
          <xsl:value-of select=""$var:v1"" />
        </FechaTransaccion>
        <xsl:if test=""string($var:v2)='true'"">
          <xsl:variable name=""var:v3"" select=""&quot;VentasNivel1&quot;"" />
          <Proceso>
            <xsl:value-of select=""$var:v3"" />
          </Proceso>
        </xsl:if>
      </Proceso>
      <Identificacion>
        <NumeroIdentificacion>
          <xsl:value-of select=""Identificacion/NumeroIdentificacion/text()"" />
        </NumeroIdentificacion>
        <xsl:variable name=""var:v4"" select=""ScriptNS0:ObtenerTipoDocumento(string(Identificacion/TipoIdentificacion/text()))"" />
        <TipoIdentificacion>
          <xsl:value-of select=""$var:v4"" />
        </TipoIdentificacion>
        <TipoCliente>
          <xsl:value-of select=""$var:v5"" />
        </TipoCliente>
      </Identificacion>
      <DatosBasicos>
        <NombreCompleto>
          <xsl:value-of select=""$var:v6"" />
        </NombreCompleto>
        <Nacionalidad>
          <xsl:value-of select=""DatosBasicos/Nacionalidad/text()"" />
        </Nacionalidad>
        <Pais>
          <xsl:value-of select=""DatosBasicos/Pais/text()"" />
        </Pais>
        <FechaNacimiento>
          <xsl:value-of select=""DatosBasicos/FechaNacimiento/text()"" />
        </FechaNacimiento>
      </DatosBasicos>
      <DatosVenta>
        <xsl:variable name=""var:v7"" select=""userCSharp:InitCumulativeSum(0)"" />
        <xsl:for-each select=""/s0:Cliente/Producto"">
          <xsl:variable name=""var:v8"" select=""userCSharp:AddToCumulativeSum(0,string(Valor/text()),&quot;1000&quot;)"" />
        </xsl:for-each>
        <xsl:variable name=""var:v9"" select=""userCSharp:GetCumulativeSum(0)"" />
        <SumaVenta>
          <xsl:value-of select=""$var:v9"" />
        </SumaVenta>
        <TotalItems>
          <xsl:value-of select=""$var:v10"" />
        </TotalItems>
      </DatosVenta>
    </ns0:ClienteSalida>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""CursoBizTalk.Utilidades, Version=1.0.0.0, Culture=neutral, PublicKeyToken=357abe667a34cc1b"" ClassName=""CursoBizTalk.Utilidades.Utils"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"CursoBizTalk.Esquemas.Cliente.Cliente";
        
        private const global::CursoBizTalk.Esquemas.Cliente.Cliente _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CursoBizTalk.Esquemas.Cliente.ClienteSalida";
        
        private const global::CursoBizTalk.Esquemas.Cliente.ClienteSalida _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"CursoBizTalk.Esquemas.Cliente.Cliente";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CursoBizTalk.Esquemas.Cliente.ClienteSalida";
                return _TrgSchemas;
            }
        }
    }
}
