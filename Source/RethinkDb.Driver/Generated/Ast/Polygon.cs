














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Polygon : ReqlExpr {

    
    
    
/// <summary>
/// <para>Construct a geometry object of type Polygon. The Polygon can be specified in one of two ways:</para>
/// <ul>
/// <li>Three or more two-item arrays, specifying longitude and latitude numbers of the polygon's vertices;</li>
/// <li>Three or more <a href="/api/javascript/point">Point</a> objects specifying the polygon's vertices.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Define a polygon.</para>
/// <code>r.table('geo').insert({
///     id: 101,
///     rectangle: r.polygon(
///         [-122.423246,37.779388],
///         [-122.423246,37.329898],
///         [-121.886420,37.329898],
///         [-121.886420,37.779388]
///     )
/// }).run(conn, callback);
/// </code></example>
        public Polygon (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Construct a geometry object of type Polygon. The Polygon can be specified in one of two ways:</para>
/// <ul>
/// <li>Three or more two-item arrays, specifying longitude and latitude numbers of the polygon's vertices;</li>
/// <li>Three or more <a href="/api/javascript/point">Point</a> objects specifying the polygon's vertices.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Define a polygon.</para>
/// <code>r.table('geo').insert({
///     id: 101,
///     rectangle: r.polygon(
///         [-122.423246,37.779388],
///         [-122.423246,37.329898],
///         [-121.886420,37.329898],
///         [-121.886420,37.779388]
///     )
/// }).run(conn, callback);
/// </code></example>
        public Polygon (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Construct a geometry object of type Polygon. The Polygon can be specified in one of two ways:</para>
/// <ul>
/// <li>Three or more two-item arrays, specifying longitude and latitude numbers of the polygon's vertices;</li>
/// <li>Three or more <a href="/api/javascript/point">Point</a> objects specifying the polygon's vertices.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Define a polygon.</para>
/// <code>r.table('geo').insert({
///     id: 101,
///     rectangle: r.polygon(
///         [-122.423246,37.779388],
///         [-122.423246,37.329898],
///         [-121.886420,37.329898],
///         [-121.886420,37.779388]
///     )
/// }).run(conn, callback);
/// </code></example>
        public Polygon (Arguments args, OptArgs optargs)
         : base(TermType.POLYGON, args, optargs) {
        }


    



    


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}
