//
//  WordGameDictionary.m
//  WordGameDictionary
//
//  Created by Andrew Eiche on 7/9/14.
//  Copyright (c) 2014 Birdcage Games LLC. All rights reserved.
//

#import "WordGameDictionary.h"

@implementation WordGameDictionary

- (instancetype)init
{
    self = [super init];
    if (self) {
        [self loadDictionary:@"ospd"];
    }
    return self;
}

- (instancetype)initWithDictionaryFile:(NSString*) dictionaryName{
    self = [super init];
    if (self) {
        [self loadDictionary:dictionaryName];
    }
    return self;
}

- (void)loadDictionary:(NSString*) dictionaryName
{
    NSString* filePath = [[NSBundle mainBundle] pathForResource:dictionaryName ofType:@"txt"];
    NSData* dictData = [[NSData alloc] initWithContentsOfFile:filePath];
    
    if (dictData != nil){
        NSString* dictText = [NSString stringWithContentsOfFile:filePath encoding:NSUTF8StringEncoding error:nil];
        if (dictText != nil){
            self.wordArray = [[NSSet alloc] initWithArray:[dictText componentsSeparatedByString:@"\n"]];
        }
    }
}

-(BOOL) checkWord:(NSString*) word minimumLength:(int)minLength{
    if (word.length < minLength) {
        return NO;
    }
    
    return [self.wordArray containsObject:word];
}

@end
