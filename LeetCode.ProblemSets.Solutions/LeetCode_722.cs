using System.Text;

public class LeetCode_722
{
    public IList<string> RemoveComments(string[] source)
    {
        var commentType = CommentType.None;
        var blockStringBuilder = new StringBuilder(80, 256);
        var result = new List<string>(100);
        
        
        for (var i = 0; i < source.Length; i++)
        {
            var nonCommentStartIndex = 0;
            for (var j = 0; j < source[i].Length; j++)
            {
                // Check comment start characteristic.
                if (commentType != CommentType.BlockStart)
                {
                    if (source[i][j] == '/' && j < source[i].Length - 1)
                    {
                        // Check block comment.
                        if (source[i][j + 1] == '*')
                        {
                            
                            if (commentType == CommentType.None)
                            {
                                blockStringBuilder.Append(source[i].Substring(nonCommentStartIndex, j - nonCommentStartIndex));
                            }
                            commentType = CommentType.BlockStart;
                            j++;
                            continue;
                        }
                        // Check line comment.
                        if (source[i][j + 1] == '/')
                        {
                                                   
                            if (commentType == CommentType.None)
                            {
                                var lineResult = source[i].Substring(0, j);

                                if (lineResult != "")
                                {
                                    result.Add(lineResult);
                                } 
                          
                            }
                            else
                            {
                                var lineResult = blockStringBuilder.ToString();
                                if (lineResult != "")
                                {
                                    result.Add(lineResult);
                                }
                                blockStringBuilder.Clear();
                            }
                            commentType = CommentType.Line;
                            break;
                        }
                    }
                    
                    if (commentType == CommentType.BlockEnd)
                    {
                        blockStringBuilder.Append(source[i][j]);
                    }
                    else
                    {
                        commentType = CommentType.None;
                    }

                }

                
                
                if (commentType == CommentType.BlockStart && source[i][j] == '*')
                {
                    if (source[i][j + 1] == '/')
                    {
                        nonCommentStartIndex = j + 2;
                        j++;
                        commentType = CommentType.BlockEnd;
                    }
                }
            }
            
            // After line processing.
            if (commentType == CommentType.None)
            {
                result.Add(source[i]);
                continue;
            }

            if (commentType == CommentType.Line)
            {
                commentType = CommentType.None;
                continue;
            }

            if (commentType == CommentType.BlockEnd)
            {
                var lineResult = blockStringBuilder.ToString();
                if (lineResult != "")
                {
                    result.Add(lineResult);
                }
                
                blockStringBuilder.Clear();
                commentType = CommentType.None;
            }
            
        }

        return result.ToArray();
    }

    public enum CommentType
    {
        None,
        Line,
        BlockStart,
        BlockEnd
    }
}