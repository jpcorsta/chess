// specify date source
            int[] scores = [3, 50, 70];

            // define scoreQuery
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 20
                select score;

            // execute query
            foreach (var i in scoreQuery)
                Console.WriteLine(i + " ");