Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace DailyActivitiesUser
    Public Class ActivityCategoryController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities

        ' GET: /ActivityCategory/
        Function Index() As ActionResult
            Return View(db.ActivityCategories.ToList())
        End Function

        ' GET: /ActivityCategory/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitycategory As ActivityCategory = db.ActivityCategories.Find(id)
            If IsNothing(activitycategory) Then
                Return HttpNotFound()
            End If
            Return View(activitycategory)
        End Function

        ' GET: /ActivityCategory/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /ActivityCategory/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "act_cat_id,name,description")> ByVal activitycategory As ActivityCategory) As ActionResult
            If ModelState.IsValid Then
                db.ActivityCategories.Add(activitycategory)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(activitycategory)
        End Function

        ' GET: /ActivityCategory/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitycategory As ActivityCategory = db.ActivityCategories.Find(id)
            If IsNothing(activitycategory) Then
                Return HttpNotFound()
            End If
            Return View(activitycategory)
        End Function

        ' POST: /ActivityCategory/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "act_cat_id,name,description")> ByVal activitycategory As ActivityCategory) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activitycategory).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(activitycategory)
        End Function

        ' GET: /ActivityCategory/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activitycategory As ActivityCategory = db.ActivityCategories.Find(id)
            If IsNothing(activitycategory) Then
                Return HttpNotFound()
            End If
            Return View(activitycategory)
        End Function

        ' POST: /ActivityCategory/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activitycategory As ActivityCategory = db.ActivityCategories.Find(id)
            db.ActivityCategories.Remove(activitycategory)
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
