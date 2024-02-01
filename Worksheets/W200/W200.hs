module Main where

-- add = \x -> (\y -> x + y)

-- roundAndDiv = \x -> (\y -> (round( x/ y))

-- double x = 2 * x

-- sumNums x y z = x + y + z

add x y = x + y

addPair (x, y) = x + y

double x = 2 * x

addXYZ x y z = x + y + z

byThePowerOf x y = x ^ y

cubeMe x = x * x * x

circleArea r = pi * r ^ 2

squareMe3 x = x ^ 2

avgThree x y z = (x + y + z) / 3

halfP x y z = (x + y + z) / 2

heronArea a b c = sqrt (s * (s - a) * (s - b) * (s - c))
  where
    s = halfP a b c

sumlist [] = 0
-- sumlist (x : xs) = x + sumlist xs
sumlist xs = head (xs) + sumlist (tail (xs))

multlist [] = 1
multlist (x : xs) = x * multlist xs

abc x
  | x == "a" = "ant"
  | x == "b" = "badger"
  | x == "c" = "camel"
  | otherwise = "hi"

greater100 x = x > 100

emptyList = []

theList = [1, 2, 3, 4]

theSecondList = 4 : [5, 6]

main = do
  putStrLn "Hello World!"
  putStrLn ("Length of " + show theList + ": " + show (length theList))
  putStrLn ("Reverse: " + show (reverse theList))
  putStrLn ("Head of theList: " + show (head theList))
  putStrLn ("Tail of theList: " + show (tail theList))
  putStrLn ("Prepend 0: " + show (0 : theList))
  putStrLn ("theList ++ theSecondList: " + show (theList ++ theSecondList))
  putStrLn ("Is " + show theList + " empty? " + show (null theList))
  putStrLn ("Is " + show (emptyList :: [Int]) + " empty? " + show (null emptyList))