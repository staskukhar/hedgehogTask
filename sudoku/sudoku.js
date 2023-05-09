function validSudoku(array)
{
    //check valid rows
    for(i = 0; i < 9; i++)
    {
        let line = new Array(9)
        for(j = 0; j < 9; j++)
        {
            line[j] = array[i][j]
        }
        if(!validLine(line)) return false
    }
    //check valid columns
    for(j = 0; j < 9; j++)
    {
        let line = new Array(9)
        for(i = 0; i < 9; i++)
        {
            line[i] = array[i][j]
        }
        if(!validLine(line)) return false
    }
    //start points of blocks
    let blockPoints = [
        [0, 0],
        [3, 0],
        [6, 0],
        [0, 3],
        [3, 3],
        [6, 3],
        [0, 6],
        [3, 6],
        [6, 6],
    ]
    //check vilid each blocks 3*3
    for(i = 0; i < blockPoints.length; i++)
    {
        if(!validBlock(getBlock(blockPoints[i, 0], blockPoints[i, 1], array))) return false
    }

    return true
}

function validLine(array)
{
    return array.length == new Set(array).size & array.indexOf(0) == -1
}

function validBlock(array)
{
    return array.length == new Set(array)
}

function getBlock(x, y, array)
{
    let block = new Array()
    for(i = x; i < x + 3; i++)
    {
        for(j = y; j < y + 3; j++)
        {
            block.push(array[i][j])
        }
    }
    return block
}

let array = [
    [5, 3, 4, 6, 7, 8, 9, 1, 2],
    [6, 7, 2, 1, 9, 5, 3, 4, 8],
    [1, 9, 8, 3, 4, 2, 5, 6, 7],
    [8, 5, 9, 7, 6, 1, 4, 2, 3],
    [4, 2, 6, 8, 5, 3, 7, 9, 1],
    [7, 1, 3, 9, 2, 4, 8, 5, 6],
    [9, 6, 1, 5, 3, 7, 2, 8, 4],
    [2, 8, 7, 4, 1, 9, 6, 3, 5],
    [3, 4, 5, 2, 8, 6, 1, 7, 9]
  ]
 
let invalidArray = [
    [5, 3, 4, 6, 7, 8, 9, 1, 2], 
    [6, 7, 2, 1, 9, 0, 3, 4, 8],
    [1, 0, 0, 3, 4, 2, 5, 6, 0],
    [8, 5, 9, 7, 6, 1, 0, 2, 0],
    [4, 2, 6, 8, 5, 3, 7, 9, 1],
    [7, 1, 3, 9, 2, 4, 8, 5, 6],
    [9, 0, 1, 5, 3, 7, 2, 1, 4],
    [2, 8, 7, 4, 1, 9, 6, 3, 5],
    [3, 0, 0, 4, 8, 1, 1, 7, 9]
  ]
  
  
console.log(validSudoku(array))
console.log(validSudoku(invalidArray))
