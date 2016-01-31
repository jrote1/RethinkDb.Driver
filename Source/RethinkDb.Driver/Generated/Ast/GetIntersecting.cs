












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

    public partial class GetIntersecting : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get all documents where the given geometry object intersects the geometry object of the requested geospatial index.</para>
/// </summary>
/// <example><para>Example: Which of the locations in a list of parks intersect <code>circle1</code>?</para>
/// <code>var circle1 = r.circle([-117.220406,32.719464], 10, {unit: 'mi'});
/// r.table('parks').getIntersecting(circle1, {index: 'area'}).run(conn, callback);
/// </code></example>
        public GetIntersecting (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get all documents where the given geometry object intersects the geometry object of the requested geospatial index.</para>
/// </summary>
/// <example><para>Example: Which of the locations in a list of parks intersect <code>circle1</code>?</para>
/// <code>var circle1 = r.circle([-117.220406,32.719464], 10, {unit: 'mi'});
/// r.table('parks').getIntersecting(circle1, {index: 'area'}).run(conn, callback);
/// </code></example>
        public GetIntersecting (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get all documents where the given geometry object intersects the geometry object of the requested geospatial index.</para>
/// </summary>
/// <example><para>Example: Which of the locations in a list of parks intersect <code>circle1</code>?</para>
/// <code>var circle1 = r.circle([-117.220406,32.719464], 10, {unit: 'mi'});
/// r.table('parks').getIntersecting(circle1, {index: 'area'}).run(conn, callback);
/// </code></example>
        public GetIntersecting (Arguments args, OptArgs optargs)
         : base(TermType.GET_INTERSECTING, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public GetIntersecting this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new GetIntersecting (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
    public GetIntersecting this[OptArgs optArgs] {
        get
        {
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
    
            return new GetIntersecting (this.Args, newOptargs);
        }
    }
    
///<summary>
/// "index": "T_STR"
///</summary>
        public GetIntersecting optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new GetIntersecting (this.Args, newOptargs);
        }


    

    


    
    }
}
