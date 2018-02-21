using System;
using System.Reflection;

namespace AutoMap
{
    public class AutoMapper : IMapper
    {
        /// <summary>
        /// Function maps a new object of the same class with the same properties
        /// </summary>
        /// <typeparam name="T">Generic type of the class to map from</typeparam>
        /// <typeparam name="T1">Generic type of the class to map</typeparam>
        /// <param name="objT">Object of the class to map from (source)</param>
        /// <returns>Function with mapping logic</returns>
        public T1 DoMapping<T, T1>(T objT) where T : class
                                           where T1 : class, new()
        {
            if(CheckNullValidity(objT)) throw new NullSourceException("The source object does not exist");
            return CreateMapProperties(objT, new T1());
        }

        /// <summary>
        /// Function maps an existing object same properties of the class T1
        /// </summary>
        /// <typeparam name="T">Generic type of the class to map from</typeparam>
        /// <typeparam name="T1">Generic type of the class to map</typeparam>
        /// <param name="objT">Object of the class to map from (source)</param>
        /// <param name="objT1">Object of the class to map (created)</param>
        /// <returns>Function with mapping logic</returns>
        public T1 DoMapping<T, T1>(T objT, T1 objT1) where T : class
                                                     where T1 : class
        {
            if (CheckNullValidity(objT)) throw new NullSourceException("The source object does not exist");
            return CreateMapProperties(objT, objT1);
        }

        public bool CheckNullValidity<T>(T obj){
            return obj == null;
        }

        /// <summary>
        /// Provides mpping of the ob
        /// </summary>
        /// <typeparam name="T">Generic type of the class to map from</typeparam>
        /// <typeparam name="T1">Generic type of the class to map</typeparam>
        /// <param name="baseObj">Object of the class to map from (source)</param>
        /// <param name="created">Object of the class to map (created)</param>
        /// <returns>Maps object1 on object2</returns>
        public T1 CreateMapProperties<T, T1>(T baseObj, T1 created)
        {
            var propT = baseObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (propT.Length == 0)
                throw new ObjectHasNoDataException("Sended object does not have data");
            
            var propT1 =
                created.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var baseObjProp in propT)
            {
                foreach (var createdObjProp in propT1)
                {
                    double verification;
                    if(double.TryParse(Convert.ToString(createdObjProp.GetValue(created)), out verification) || verification == 0.0){
                        if (createdObjProp.PropertyType.Namespace == "System")
                        {
                            if (baseObjProp.PropertyType.Namespace != "System")
                                CreateMapProperties(baseObjProp.GetValue(baseObj), created);

                            if (baseObjProp.Name.Equals(createdObjProp.Name, StringComparison.OrdinalIgnoreCase) && String.Equals(baseObjProp.PropertyType, createdObjProp.PropertyType))
                                createdObjProp.SetValue(created, baseObjProp.GetValue(baseObj));
                        }
                        if (createdObjProp.PropertyType.Namespace != "System")
                            createdObjProp.SetValue(created, CreateMapProperties(baseObj, createdObjProp.GetValue(created)));
                    }
                }
            }
            return created;
        }
    }
}
