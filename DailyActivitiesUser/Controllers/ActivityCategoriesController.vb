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
    Public Class ActivityCategoriesController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities1

        ' GET: ActivityCategories
        Function Index() As ActionResult
            Return View(db.ActivityCategories.ToList())
        End Function

        ' GET: ActivityCategories/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activityCategory As ActivityCategory = db.ActivityCategories.Find(id)
            If IsNothing(activityCategory) Then
                Return HttpNotFound()
            End If
            Return View(activityCategory)
        End Function

        ' GET: ActivityCategories/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: ActivityCategories/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="act_cat_id,name,description")> ByVal activityCategory As ActivityCategory) As ActionResult
            If ModelState.IsValid Then
                db.ActivityCategories.Add(activityCategory)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(activityCategory)
        End Function

        ' GET: ActivityCategories/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activityCategory As ActivityCategory = db.ActivityCategories.Find(id)
            If IsNothing(activityCategory) Then
                Return HttpNotFound()
            End If
            Return View(activityCategory)
        End Function

        ' POST: ActivityCategories/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="act_cat_id,name,description")> ByVal activityCategory As ActivityCategory) As ActionResult
            If ModelState.IsValid Then
                db.Entry(activityCategory).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(activityCategory)
        End Function

        ' GET: ActivityCategories/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim activityCategory As ActivityCategory = db.ActivityCategories.Find(id)
            If IsNothing(activityCategory) Then
                Return HttpNotFound()
            End If
            Return View(activityCategory)
        End Function

        ' POST: ActivityCategories/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim activityCategory As ActivityCategory = db.ActivityCategories.Find(id)
            db.ActivityCategories.Remove(activityCategory)
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
