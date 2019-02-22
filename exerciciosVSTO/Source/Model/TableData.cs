using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace exerciciosVSTO.Source.Model
{
    [XmlRootAttribute(ElementName = "TableData", Namespace = GlobalVars.MY_NAMESPACE)]
    class TableData
    {
        [XmlAttribute(AttributeName = "LinesText")]
        public string LinesText { get; set; }

        [XmlAttribute(AttributeName = "ColumnsText")]
        public string ColumnsText { get; set; }
    }
}
