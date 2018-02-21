namespace AutoMap
{
    interface IMapper
    {
        /// <summary>
        /// Declaration of the method which map the same object of the same type T
        /// </summary>
        /// <typeparam name="T">Generic type of the objT</typeparam>
        /// <typeparam name="T1">Generic type of the object to create</typeparam>
        /// <param name="objT">Sended object as a parameter as a base mapping </param>
        /// <returns>Object with the T1 type</returns>
        T1 DoMapping<T, T1>(T objT) where T : class
                            where T1 : class, new();
        T1 DoMapping<T, T1>(T objT, T1 objT1) where T : class
                                              where T1 : class;
    }
}
