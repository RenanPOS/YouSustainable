using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ServiceLayer.Controllers
{
    public class NHibernateContractResolver : DefaultContractResolver
    {
        protected override List<MemberInfo> GetSerializableMembers(Type objectType)
        {
            if (typeof(NHibernateContractResolver).IsAssignableFrom(objectType))
            {
                return base.GetSerializableMembers(objectType.BaseType);
            }
            else
            {
                return base.GetSerializableMembers(objectType);
            }
        }

        public static string gerarJSON(Object objeto)
        {
            var serializer = new JsonSerializer
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new NHibernateContractResolver()
            };
            StringWriter stringWriter = new StringWriter();
            JsonWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(stringWriter);
            serializer.Serialize(jsonWriter, objeto);
            string serializedObject = stringWriter.ToString();
            return JsonConvert.SerializeObject(objeto);
        }
    }
}