












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Circle : ReqlExpr {

    
    
    
/// <summary>
/// <para>Construct a circular line or polygon. A circle in RethinkDB is a polygon or line <em>approximating</em> a circle of a given radius around a given center, consisting of a specified number of vertices (default 32).</para>
/// </summary>
/// <example><para>Example: Define a circle.</para>
/// <code>r.table('geo').insert({
///     id: 300,
///     name: 'Hayes Valley',
///     neighborhood: r.circle([-122.423246,37.779388], 1000)
/// }).run(conn, callback);
/// </code></example>
        public Circle (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Construct a circular line or polygon. A circle in RethinkDB is a polygon or line <em>approximating</em> a circle of a given radius around a given center, consisting of a specified number of vertices (default 32).</para>
/// </summary>
/// <example><para>Example: Define a circle.</para>
/// <code>r.table('geo').insert({
///     id: 300,
///     name: 'Hayes Valley',
///     neighborhood: r.circle([-122.423246,37.779388], 1000)
/// }).run(conn, callback);
/// </code></example>
        public Circle (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Construct a circular line or polygon. A circle in RethinkDB is a polygon or line <em>approximating</em> a circle of a given radius around a given center, consisting of a specified number of vertices (default 32).</para>
/// </summary>
/// <example><para>Example: Define a circle.</para>
/// <code>r.table('geo').insert({
///     id: 300,
///     name: 'Hayes Valley',
///     neighborhood: r.circle([-122.423246,37.779388], 1000)
/// }).run(conn, callback);
/// </code></example>
        public Circle (Arguments args, OptArgs optargs)
         : base(TermType.CIRCLE, args, optargs) {
        }


    



    
///<summary>
/// "num_vertices": "T_EXPR",
///  "geo_system": "E_GEO_SYSTEM",
///  "unit": "E_UNIT",
///  "fill": "T_BOOL"
///</summary>
        public Circle this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Circle (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "num_vertices": "T_EXPR",
///  "geo_system": "E_GEO_SYSTEM",
///  "unit": "E_UNIT",
///  "fill": "T_BOOL"
///</summary>
    public Circle this[OptArgs optArgs] {
        get
        {
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
    
            return new Circle (this.Args, newOptargs);
        }
    }
    
///<summary>
/// "num_vertices": "T_EXPR",
///  "geo_system": "E_GEO_SYSTEM",
///  "unit": "E_UNIT",
///  "fill": "T_BOOL"
///</summary>
        public Circle optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Circle (this.Args, newOptargs);
        }


    

    


    
    }
}
