Public Class Form_RandomProblem
    Dim question As String
    Dim answer As String

    Dim qa(,) As String = {
        {"What does www stand for in a website browser?", "World Wide Web"},
        {"How long is an Olympic swimming pool (in meters)?", "50 meters"},
        {"What countries made up the original Axis powers in World War II?", "Germany, Italy, and Japan"},
        {"Which country do cities of Perth, Adelade & Brisbane belong to?", "Australia"},
        {"What geometric shape is generally used for stop signs?", "Octagon"},
        {"What is cynophobia?", "Fear of dogs"},
        {"What punctuation mark ends an imperative sentence?", "A period or exclamation point"},
        {"Who named the Pacific Ocean?", "Ferdinand Magellan"},
        {"How many languages are written from right to left?", "12"},
        {"Q: How many countries still have the shilling as currency? Bonus point: Which countries?", "Four, Kenya, Uganda, Tanzania, and Somalia"},
        {"What is the name of the man who launched eBay back in 1995?", "Pierre Omidyar"},
        {"What is the name of the biggest technology company in South Korea?", "Samsung"},
        {"Which animal can be seen on the Porsche logo?", "Horse"},
        {"Which monarch officially made Valentine's Day a holiday in 1537?", "Henry VIII"},
        {"Who was the first woman to win a Nobel Prize (in 1903)?", "Marie Curie"},
        {"The first dictionary was written by?", "Robert Cawdrey"},
        {"Worship of Krishna is observed by which Religious Faith?", "Hinduism"},
        {"What is the name of the largest ocean on earth?", "Pacific Ocean"},
        {"Demolition of the Berlin wall separating East and West Germany began in what year?", "1989"},
        {"What is the romanized Arabic word for moon?", "Qamar"},
        {"Who was the first woman pilot to fly solo across the Atlantic?", "Amelia Earhart"}
    }

    Dim randomIndex As Integer = Int(Rnd() * qa.Length / 2)

    Private Sub Form_RandomProblem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        getQuestion()
    End Sub

    Sub getQuestion()
        question = qa(randomIndex, 0)
        answer = qa(randomIndex, 1)
        Label_Card.Text = question

    End Sub

    Private Sub Label_Card_Click(sender As Object, e As EventArgs) Handles Label_Card.Click
        ' if Label_Card.Text = answer, change it to question, or vice versa
        If Label_Card.Text = answer Then
            Label_Card.Text = question
        Else
            Label_Card.Text = answer
        End If
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        ' increment the index, it it goes above the length of the array, reset it to 0
        randomIndex += 1
        If randomIndex >= qa.Length / 2 Then
            randomIndex = 0
        End If

        getQuestion()
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        ' decrement the index, it it goes below 0, reset it to the last index
        randomIndex -= 1
        If randomIndex < 0 Then
            randomIndex = qa.Length / 2 - 1
        End If

        getQuestion()
    End Sub
End Class
