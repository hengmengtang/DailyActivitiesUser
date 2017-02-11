Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports DailyActivitiesUser

Namespace Controllers
    Public Class ActivitySubCategoriesController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities1

        ' GET: ActivitySubCategories
        Function Index() As ActionResult
            Dim activitySubCategories = db.ActivitySubCategories.Include(Function(a) a.ActivityCategory)
            Return View(activitySubCategories.ToList())
        End Function

        ' GET: ActivitySubCategories/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitySubCategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            If IsNothing(activitySubCategory) Then
                Return HttpNotFound()
            End If
            Return View(activitySubCategory)
        End Function

        ' GET: ActivitySubCategories/Create
        Function Create() As ActionResult
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name")
            Return View()
        End Function

        ' POST: ActivitySubCategories/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="act_sub_cat_id,act_cat_id,name,description")> ByVal activitySubCategory As ActivitySubCategory) As ActionResult
            If ModelState.IsValid Then
                db.ActivitySubCategories.Add(activitySubCategory)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name", activitySubCategory.act_cat_id)
            Return View(activitySubCategory)
        End Function

        ' GET: ActivitySubCategories/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitySubCategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            If IsNothing(activitySubCategory) Then
                Return HttpNotFound()
            End If
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name", activitySubCategory.act_cat_id)
            Return View(activitySubCategory)
        End Function

        ' POST: ActivitySubCategories/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="act_sub_cat_id,act_cat_id,name,description")> ByVal activitySubCategory As ActivitySubCategory) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activitySubCategory).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.act_cat_id = New SelectList(db.ActivityCategories, "act_cat_id", "name", activitySubCategory.act_cat_id)
            Return View(activitySubCategory)
        End Function

        ' GET: ActivitySubCategories/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitySubCategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            If IsNothing(activitySubCategory) Then
                Return HttpNotFound()
            End If
            Return View(activitySubCategory)
        End Function

        ' POST: ActivitySubCategories/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activitySubCategory As ActivitySubCategory = db.ActivitySubCategories.Find(id)
            db.ActivitySubCategories.Remove(activitySubCategory)
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
