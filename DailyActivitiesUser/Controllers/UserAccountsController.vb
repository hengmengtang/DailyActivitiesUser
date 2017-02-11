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
    Public Class UserAccountsController
        Inherits System.Web.Mvc.Controller

        Private db As New DailyActivityDBEntities1

        ' GET: UserAccounts
        Function Index() As ActionResult
            Return View(db.UserAccounts.ToList())
        End Function

        ' GET: UserAccounts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim userAccount As UserAccount = db.UserAccounts.Find(id)
            If IsNothing(userAccount) Then
                Return HttpNotFound()
            End If
            Return View(userAccount)
        End Function

        ' GET: UserAccounts/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: UserAccounts/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="user_id,first_name,last_name,username,gender,email,password,confirmpassword")> ByVal userAccount As UserAccount) As ActionResult
            If ModelState.IsValid Then
                db.UserAccounts.Add(userAccount)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(userAccount)
        End Function

        ' GET: UserAccounts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim userAccount As UserAccount = db.UserAccounts.Find(id)
            If IsNothing(userAccount) Then
                Return HttpNotFound()
            End If
            Return View(userAccount)
        End Function

        ' POST: UserAccounts/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="user_id,first_name,last_name,username,gender,email,password,confirmpassword")> ByVal userAccount As UserAccount) As ActionResult
            If ModelState.IsValid Then
                db.Entry(userAccount).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(userAccount)
        End Function

        ' GET: UserAccounts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim userAccount As UserAccount = db.UserAccounts.Find(id)
            If IsNothing(userAccount) Then
                Return HttpNotFound()
            End If
            Return View(userAccount)
        End Function

        ' POST: UserAccounts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim userAccount As UserAccount = db.UserAccounts.Find(id)
            db.UserAccounts.Remove(userAccount)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Function Login() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Public Function Login(user1 As UserAccount) As ActionResult
            Using db As New DailyActivityDBEntities1

                With db
                    Dim user = .UserAccounts.Where(Function(u As UserAccount) u.username = user1.username And u.password = user1.password).FirstOrDefault
                    If user IsNot Nothing Then
                        Session("user_id") = user.user_id.ToString
                        Session("username") = user.username.ToString
                        Return RedirectToAction("Activities")
                    Else
                        Return View()
                    End If

                End With

            End Using
            Return View()
        End Function

    End Class
End Namespace
