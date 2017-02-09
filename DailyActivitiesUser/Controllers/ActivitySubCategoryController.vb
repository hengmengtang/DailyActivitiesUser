Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesUser
    Public Class ActivitySubCategoryController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /ActivitySubCategory/
        Function Index() As ActionResult
            Dim activitysubcategories = db.ActivitySubCategories.Include(Function(a) a.ActivityCategory)
            Return View(activitysubcategories.ToList())
        End Function

        ' GET: /ActivitySubCategory/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitysubcategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            If IsNothing(activitysubcategory) Then
                Return HttpNotFound()
            End If
            Return View(activitysubcategory)
        End Function

        ' GET: /ActivitySubCategory/Create
        Function Create() As ActionResult
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name")
            Return View()
        End Function

        ' POST: /ActivitySubCategory/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "act_sub_cat_id,act_cat_id,name,description")> ByVal activitysubcategory As ActivitySubCategory) As ActionResult
            If ModelState.IsValid Then
                db.ActivitySubCategories.Add(activitysubcategory)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name", activitysubcategory.act_cat_id)
            Return View(activitysubcategory)
        End Function

        ' GET: /ActivitySubCategory/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitysubcategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            If IsNothing(activitysubcategory) Then
                Return HttpNotFound()
            End If
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name", activitysubcategory.act_cat_id)
            Return View(activitysubcategory)
        End Function

        ' POST: /ActivitySubCategory/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "act_sub_cat_id,act_cat_id,name,description")> ByVal activitysubcategory As ActivitySubCategory) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activitysubcategory).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name", activitysubcategory.act_cat_id)
            Return View(activitysubcategory)
        End Function

        ' GET: /ActivitySubCategory/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitysubcategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            If IsNothing(activitysubcategory) Then
                Return HttpNotFound()
            End If
            Return View(activitysubcategory)
        End Function

        ' POST: /ActivitySubCategory/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activitysubcategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            db.ActivitySubCategories.Remove(activitysubcategory)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
